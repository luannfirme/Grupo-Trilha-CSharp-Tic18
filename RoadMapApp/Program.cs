using RoadMapApp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => All.View());
app.MapGet("/luannfirme", () => LuannFirme.View());
app.MapGet("/pauloricardo", () => PauloRicardo.View());
app.MapGet("/anacaroline", () => AnaCaroline.View());
app.MapGet("/caio", () => Caio.View());

app.Run();
