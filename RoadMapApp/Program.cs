using RoadMapApp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/pauloricardo", () => PauloRicardo.View());
app.MapGet("/caio", () => Caio.View());

app.Run();
