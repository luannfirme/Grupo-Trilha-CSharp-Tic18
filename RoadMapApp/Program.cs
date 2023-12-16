using RoadMapApp;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => All.View());
app.Run();
