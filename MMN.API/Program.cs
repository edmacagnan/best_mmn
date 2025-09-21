using MMN.API.Helpers;
using MMN.BL.Helpers;
using MMN.DL.Helpers;

var builder = WebApplication.CreateBuilder(args);

builder.AddDataLayer();
builder.AddBusinessLogic();
builder.AddApiLayer();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();