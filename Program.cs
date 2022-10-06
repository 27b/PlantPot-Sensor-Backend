using PlantPotServices;
using PlantPotDTO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/status", () => "Online");

app.MapGet("/plant-pot", () => PlantPotService.RetrieveList());

app.MapGet("/plant-pot/{name}", (string name) => PlantPotService.Retrieve(name));

app.MapPost("/plant-pot", (PlantPotDto pot) => PlantPotService.Append(pot));

app.MapPut("/plant-pot", (PlantPotDto pot) => PlantPotService.Update(pot));

app.Run();
