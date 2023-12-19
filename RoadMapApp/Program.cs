using RoadMapApp;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/anacaroline", () => AnaCaroline.View());
app.Run();
