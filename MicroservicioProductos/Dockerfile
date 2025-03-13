# Usar la imagen de .NET 8
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Imagen para compilar
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar el archivo del proyecto
COPY ./*.csproj ./
RUN dotnet restore 

# Copiar el resto del código y compilar
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Usar la imagen base para ejecutar el microservicio
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "MicroservicioProductos.dll"]
