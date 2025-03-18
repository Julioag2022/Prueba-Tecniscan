# ArithmeticApp

Este proyecto fue desarrollado como parte de una prueba técnica para evaluar habilidades en desarrollo web y backend. Consiste en una aplicación web Angular que interactúa con una API de C# para realizar operaciones aritméticas.

## Estructura del Proyecto

* `arithmetic-app/`: Contiene la aplicación Angular creada con Angular CLI versión 18.0.7 y desarrollada en Visual Studio Code.
* `ArithmeticAPI/`: Contiene la API de C# (.NET 8) desarrollada en Visual Studio 2022.

## Criterios de Evaluación

* **Funcionalidad:** La aplicación realiza correctamente las operaciones aritméticas y muestra los resultados.
* **Código:** El código está limpio, organizado y utiliza patrones de diseño adecuados.
* **Documentación:** Este README proporciona instrucciones claras para ejecutar la aplicación y la API.
* **Diseño:** La interfaz es sencilla, clara y fácil de usar, con validación de campos de entrada y advertencias.
* **Interfaz Gráfica:** El formulario tiene una presentación y diseño claros.

## Aplicación Angular

### Servidor de Desarrollo

Ejecuta `ng serve` para iniciar el servidor de desarrollo local. Navega a `http://localhost:4200/` en tu navegador. La aplicación se recargará automáticamente al guardar cambios en los archivos fuente.

### Generación de Componentes y Otros Elementos

Utiliza `ng generate component component-name` para crear nuevos componentes. Similarmente, puedes generar directivas, pipes, servicios, clases, guards, interfaces, enums y módulos.

### Construcción para Producción

Ejecuta `ng build` para compilar la aplicación. Los archivos resultantes se almacenan en el directorio `dist/`.

### Pruebas

* **Pruebas Unitarias:** Ejecuta `ng test` para realizar pruebas unitarias con Karma.
* **Pruebas End-to-End:** Ejecuta `ng e2e` para pruebas end-to-end (requiere configuración adicional).

### Ayuda Adicional

Consulta `ng help` o la [Documentación de Angular CLI](https://angular.dev/tools/cli) para más información.

## API de C#

Desarrollada en Visual Studio 2022, la API ArithmeticAPI expone endpoints para realizar operaciones aritméticas.

### Requisitos

* .NET 8 SDK

### Ejecución

1.  Abre el proyecto `ArithmeticAPI` en Visual Studio 2022.
2.  Ejecuta la API desde Visual Studio o usando `dotnet run` en la terminal dentro del directorio del proyecto.
3.  La API estará disponible en `https://localhost:7151/api/Arithmetic`.

### Endpoints

* `GET https://localhost:7151/api/Arithmetic/sum/{num1}/{num2}`: Suma dos números.
* `GET https://localhost:7151/api/Arithmetic/subtract/{num1}/{num2}`: Resta dos números.
* `GET https://localhost:7151/api/Arithmetic/multiply/{num1}/{num2}`: Multiplica dos números.
* `GET https://localhost:7151/api/Arithmetic/divide/{num1}/{num2}`: Divide dos números.

### Interacción con Angular

La aplicación Angular consume los endpoints de la API para realizar operaciones aritméticas. Asegúrate de que la API esté en ejecución y que la URL en la aplicación Angular esté configurada correctamente.

## Configuración

* La URL base de la API en la aplicación Angular debe apuntar a `https://localhost:7151/api/Arithmetic`.
* Si utilizas variables de entorno, asegúrate de configurarlas correctamente en tu entorno de desarrollo y producción.

## Dependencias

* Ejecuta `npm install` en el directorio `arithmetic-app/` para instalar las dependencias de Angular.
* Asegúrate de tener el SDK de .NET 8 instalado para ejecutar la API de C#.

## Notas Adicionales

* La API de C# fue creada utilizando Visual Studio 2022, lo que facilita su desarrollo y depuración.
* La aplicación Angular se desarrolló en Visual Studio Code, aprovechando su versatilidad y las extensiones disponibles para el desarrollo web.
* Asegúrate de que tanto la API como la aplicación Angular estén en ejecución para probar la funcionalidad completa del proyecto.

## Capturas de Pantalla

## Capturas de Pantalla

### Ingreso de Números y Selección de Operación
![Ingreso de Números](https://i.postimg.cc/htxCWtkj/Whats-App-Image-2025-03-17-at-19-34-53.jpg)

### Botón Calcular y Resultado
![Botón Calcular y Resultado](https://drive.google.com/file/d/1I8C8OMV2TxHk22DzroyTpTYALDYIsbfT/view?usp=sharing)

### Endpoints de la API
![Endpoints de la API](https://drive.google.com/file/d/1qXokyxRHpb8xvKuN-XDsb4MaX_5nN3JO/view?usp=sharing)
