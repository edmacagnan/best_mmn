using MMN.BL.StateMachines.Company;

namespace MMN.BL.Tests;

public class SmTests {

    [Test]
    public void GenerateCompanyGraph() {
        var machine = new CompanyMachine();
        Console.WriteLine(machine.GetDotRepresentation());
    }
}