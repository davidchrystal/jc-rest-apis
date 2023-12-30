using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRepositories(builder.Configuration);
var app = builder.Build();
app.Services.MigrateDb();
app.MapGamesEndpoints();
app.Run();