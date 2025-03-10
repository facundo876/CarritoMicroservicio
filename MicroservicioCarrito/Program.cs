var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var carrito = new List<object>();

app.MapGet("/api/carrito", () => carrito);

app.MapPost("/api/carrito", (int id, string nombre, decimal precio) =>
{
    var item = new { Id = id, Nombre = nombre, Precio = precio };
    carrito.Add(item);
    return Results.Ok(item);
});

app.Run();
