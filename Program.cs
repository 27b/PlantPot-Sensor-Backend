using PlantPotDTO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<PlantPot> PlantPotList = new List<PlantPot>();

app.MapGet("/status", () => "Online");

app.MapGet("/plant-pot", () => PlantPotList);

app.MapPost("/plant-pot", (PlantPot pot) => PlantPotList.Add(pot));

app.MapGet("/plant-pot/{name}", (string name) => PlantPotList.FirstOrDefault(item => item.name == name));

app.MapPut("/plant-pot", (PlantPot pot) => {
    var result = PlantPotList.FirstOrDefault(item => item.name == pot.name);
    if (result != null) result.temperature = pot.temperature;
});

app.Run();
