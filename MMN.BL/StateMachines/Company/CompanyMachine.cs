using TheStateMachine;
using TheStateMachine.Models;

namespace MMN.BL.StateMachines.Company;

public class CompanyMachineData : StateMachineData<CompanyStates, ReactionType> {
    public override CompanyStates CurrentState {
        get => Enum.Parse<CompanyStates>(Company.State);
        set => Company.State = value.ToString();
    }

    public DL.Models.Company Company { get; set; }

    public CompanyMachineData(DL.Models.Company company) {
        Company = company;
    }
}

public class CompanyMachine : StateMachine<CompanyStates, CompanyTransitions, CompanyMachineData> {
    public CompanyMachine() : base("Company") {
        AddState(CompanyStates.New, nameof(CompanyStates.New), false);
        AddState(CompanyStates.Active, nameof(CompanyStates.Active), true);
        AddState(CompanyStates.Inactive,  nameof(CompanyStates.Inactive), true);

        AddStateCommand(CompanyStates.New, CompanyTransitions.Auto, CommandOption.Hidden());
        AddStateCommand(CompanyStates.Active, CompanyTransitions.Deactivate, CommandOption.Primary());
        AddStateCommand(CompanyStates.Inactive, CompanyTransitions.Activate, CommandOption.Primary());

        FromState(CompanyStates.New)
            .WithCommand(CompanyTransitions.Auto)
            .ToState(CompanyStates.Active);
        
        FromState(CompanyStates.Active)
            .WithCommand(CompanyTransitions.Deactivate)
            .ToState(CompanyStates.Inactive);
        
        FromState(CompanyStates.Inactive)
            .WithCommand(CompanyTransitions.Activate)
            .ToState(CompanyStates.Active);
    }
}