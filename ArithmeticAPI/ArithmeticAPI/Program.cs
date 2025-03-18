using static System.Net.WebRequestMethods; // Importa m�todos est�ticos de WebRequestMethods (no usado directamente en este c�digo)

var builder = WebApplication.CreateBuilder(args); // Crea un WebApplicationBuilder para configurar la aplicaci�n

// HABILITAR CORS (Cross-Origin Resource Sharing)
builder.Services.AddCors(options => // Agrega el servicio CORS al contenedor de dependencias
{
    options.AddPolicy("AllowAngularApp", // Define una pol�tica CORS llamada "AllowAngularApp"
        policy =>
        {
            policy.WithOrigins("http://localhost:4200") // Especifica el origen permitido (la URL de tu aplicaci�n Angular). Aseg�rate de que no haya una barra diagonal al final.
                  .AllowAnyHeader() // Permite cualquier encabezado en las solicitudes
                  .AllowAnyMethod(); // Permite cualquier m�todo HTTP (GET, POST, PUT, DELETE, etc.)
        });
});

builder.Services.AddControllers(); // Agrega servicios para controladores API

builder.Services.AddEndpointsApiExplorer(); // Agrega servicios para la exploraci�n de endpoints de API (necesario para Swagger)
builder.Services.AddSwaggerGen(); // Agrega el generador de Swagger para la documentaci�n de la API

var app = builder.Build(); // Construye la aplicaci�n web

if (app.Environment.IsDevelopment()) // Verifica si la aplicaci�n se ejecuta en modo de desarrollo
{
    app.UseSwagger(); // Habilita Swagger para la documentaci�n de la API
    app.UseSwaggerUI(); // Habilita la interfaz de usuario de Swagger
}

app.UseHttpsRedirection(); // Redirige las solicitudes HTTP a HTTPS

// ACTIVAR POL�TICA DE CORS
app.UseCors("AllowAngularApp"); // Aplica la pol�tica CORS "AllowAngularApp" a todas las solicitudes

app.UseAuthorization(); // Habilita la autorizaci�n para proteger los endpoints

app.MapControllers(); // Mapea los controladores API a sus rutas correspondientes

app.Run(); // Inicia la aplicaci�n web