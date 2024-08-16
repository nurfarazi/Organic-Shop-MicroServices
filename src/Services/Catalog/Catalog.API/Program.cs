using Carter;
using Marten;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();

builder.Services.AddMediatR(configuration => { configuration.RegisterServicesFromAssembly(typeof(Program).Assembly); });
builder.Services.AddMarten(option =>
{
    option.Connection(builder.Configuration.GetConnectionString("Database") ?? string.Empty);
}).UseLightweightSessions();

var app = builder.Build();

app.MapCarter();

app.Run();