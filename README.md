![image](https://github.com/user-attachments/assets/691df313-e220-46b4-b4fb-c711fff2501e)

# 🚀 CarritoMicroservicios - Arquitectura de Microservicios en .NET 8

## 📌 Descripción
Este proyecto implementa un sistema de **Carrito de Compras** basado en una **arquitectura de microservicios** usando **.NET 8**, **Ocelot API Gateway** y **Docker Compose**.

🔹 **Tecnologías principales:**
- .NET 8 (Minimal APIs)
- Ocelot (API Gateway)
- Docker & Docker Compose
- RESTful APIs

## 🏗️ Arquitectura del Proyecto

```
📂 CarritoMicroservicios
 ├── 📂 ApiGateway
 │   ├── Dockerfile
 │   ├── Program.cs
 │   ├── ocelot.json
 │   └── ApiGateway.csproj
 │
 ├── 📂 MicroservicioProductos
 │   ├── Dockerfile
 │   ├── Program.cs
 │   └── MicroservicioProductos.csproj
 │
 ├── 📂 MicroservicioCarrito
 │   ├── Dockerfile
 │   ├── Program.cs
 │   └── MicroservicioCarrito.csproj
 │
 ├── 📂 MicroservicioUsuarios
 │   ├── Dockerfile
 │   ├── Program.cs
 │   └── MicroservicioUsuarios.csproj
 │
 ├── docker-compose.yml
 ├── CarritoMicroservicios.sln
 └── README.md
```

## 🛠️ Configuración y Ejecución
### 🔹 1. Clonar el repositorio
```bash
git clone https://github.com/tu-usuario/CarritoMicroservicios.git
cd CarritoMicroservicios
```

### 🔹 2. Construir y ejecutar los contenedores con Docker
```bash
docker-compose up --build
```

### 🔹 3. Verificar los servicios
- Microservicio Productos: [http://localhost:5001/api/productos](http://localhost:5001/api/productos)
- Microservicio Carrito: [http://localhost:5002/api/carrito](http://localhost:5001/api/carrito)
- Microservicio Usuarios: [http://localhost:5003/api/usuarios](http://localhost:5001/api/usuarios)

## 📌 Endpoints Disponibles
### 🔹 Productos (`/api/productos`)
- `GET /api/productos` → Obtener lista de productos

### 🔹 Carrito (`/api/carrito`)
- `GET /api/carrito` → Obtener contenido del carrito
- `POST /api/carrito?id=1&nombre=Laptop&precio=1000` → Agregar producto al carrito

### 🔹 Usuarios (`/api/usuarios`)
- `GET /api/usuarios` → Obtener información de usuario

## 📜 Licencia
Este proyecto está bajo la **Licencia MIT**. ¡Siéntete libre de contribuir! 😃

