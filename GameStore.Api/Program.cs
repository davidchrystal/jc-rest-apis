using GameStore.Api;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IGamesRepository, InMemGamesRepository>();
var connString = builder.Configuration.GetConnectionString("GameStoreContext");
var app = builder.Build();
app.MapGamesEndpoints();
app.Run();