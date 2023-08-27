using Infra;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructure();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.Run();
