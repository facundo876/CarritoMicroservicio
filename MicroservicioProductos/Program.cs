var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/productos", () =>
{
    return new[]
    {
        new { Id = 1, Nombre = "Laptop", Precio = 1000 },
        new { Id = 2, Nombre = "Mouse", Precio = 20 }
    };
});

app.Run();
