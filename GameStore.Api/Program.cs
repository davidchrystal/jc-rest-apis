using GameStore.Api;
using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IGamesRepository, InMemGamesRepository>();
var connString = builder.Configuration.GetConnectionString("GameStoreContext");
builder.Services.AddSqlServer<GameStoreContext>(connString);

var app = builder.Build();
app.Services.MigrateDb();
app.MapGamesEndpoints();
app.Run();