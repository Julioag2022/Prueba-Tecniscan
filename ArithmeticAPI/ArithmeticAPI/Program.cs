using static System.Net.WebRequestMethods; // Importa métodos estáticos de WebRequestMethods (no usado directamente en este código)

var builder = WebApplication.CreateBuilder(args); // Crea un WebApplicationBuilder para configurar la aplicación

// HABILITAR CORS (Cross-Origin Resource Sharing)
builder.Services.AddCors(options => // Agrega el servicio CORS al contenedor de dependencias
{
    options.AddPolicy("AllowAngularApp", // Define una política CORS llamada "AllowAngularApp"
        policy =>
        {
            policy.WithOrigins("http://localhost:4200") // Especifica el origen permitido (la URL de tu aplicación Angular). Asegúrate de que no haya una barra diagonal al final.
                  .AllowAnyHeader() // Permite cualquier encabezado en las solicitudes
                  .AllowAnyMethod(); // Permite cualquier método HTTP (GET, POST, PUT, DELETE, etc.)
        });
});

builder.Services.AddControllers(); // Agrega servicios para controladores API

builder.Services.AddEndpointsApiExplorer(); // Agrega servicios para la exploración de endpoints de API (necesario para Swagger)
builder.Services.AddSwaggerGen(); // Agrega el generador de Swagger para la documentación de la API

var app = builder.Build(); // Construye la aplicación web

if (app.Environment.IsDevelopment()) // Verifica si la aplicación se ejecuta en modo de desarrollo
{
    app.UseSwagger(); // Habilita Swagger para la documentación de la API
    app.UseSwaggerUI(); // Habilita la interfaz de usuario de Swagger
}

app.UseHttpsRedirection(); // Redirige las solicitudes HTTP a HTTPS

// ACTIVAR POLÍTICA DE CORS
app.UseCors("AllowAngularApp"); // Aplica la política CORS "AllowAngularApp" a todas las solicitudes

app.UseAuthorization(); // Habilita la autorización para proteger los endpoints

app.MapControllers(); // Mapea los controladores API a sus rutas correspondientes

app.Run(); // Inicia la aplicación web