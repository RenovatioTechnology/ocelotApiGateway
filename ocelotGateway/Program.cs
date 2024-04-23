using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

// As a web API project, we need to enable couple of middlewares
app.UseHttpsRedirection();

app.UseAuthentication();

app.MapControllers();

await app.UseOcelot();

app.Run();
