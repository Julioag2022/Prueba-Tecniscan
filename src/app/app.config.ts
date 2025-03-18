// Importa ApplicationConfig y una función para mejorar el rendimiento de detección de cambios (Zone.js)
import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';

// Importa la función para configurar el enrutamiento en Angular
import { provideRouter } from '@angular/router';

// Importa la función que provee el cliente HTTP para hacer peticiones a APIs
import { provideHttpClient } from '@angular/common/http'; // Necesaria para poder usar HttpClient en la app

// Importa las rutas definidas en tu archivo de rutas
import { routes } from './app.routes';


// Exporta la configuración principal de la aplicación Angular
export const appConfig: ApplicationConfig = {
  providers: [
    provideZoneChangeDetection({ eventCoalescing: true }), // Mejora la eficiencia del sistema de detección de cambios
    provideRouter(routes),                                 // Establece las rutas de navegación de la app
    provideHttpClient()                                    // Permite usar servicios HTTP en la app
  ]
};