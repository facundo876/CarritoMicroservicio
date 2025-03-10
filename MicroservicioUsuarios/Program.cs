var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/usuarios", () =>
{
    return new { Id = 1, Nombre = "Juan", Email = "juan@example.com" };
});

app.Run();
