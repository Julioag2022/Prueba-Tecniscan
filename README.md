# ArithmeticApp

Este proyecto fue generado con [Angular CLI](https://github.com/angular/angular-cli) versión 18.0.7.

## Descripción

ArithmeticApp es una aplicación web Angular que interactúa con una API de C# para realizar operaciones aritméticas.

## Estructura del Proyecto

El proyecto está organizado de la siguiente manera:

* `arithmetic-app/`: Contiene la aplicación Angular.
* `ArithmeticAPI/`: Contiene la API de C# (.NET 8).

## Aplicación Angular

### Servidor de Desarrollo

Ejecuta `ng serve` para iniciar el servidor de desarrollo. Navega a `http://localhost:4200/`. La aplicación se recargará automáticamente si cambias alguno de los archivos fuente.

### Generación de Código

Ejecuta `ng generate component component-name` para generar un nuevo componente. También puedes usar `ng generate directive|pipe|service|class|guard|interface|enum|module`.

### Construcción

Ejecuta `ng build` para construir el proyecto. Los artefactos de construcción se almacenarán en el directorio `dist/`.

### Pruebas Unitarias

Ejecuta `ng test` para ejecutar las pruebas unitarias a través de [Karma](https://karma-runner.github.io).

### Pruebas End-to-End

Ejecuta `ng e2e` para ejecutar las pruebas end-to-end a través de una plataforma de tu elección. Para usar este comando, primero debes agregar un paquete que implemente capacidades de pruebas end-to-end.

### Ayuda Adicional

Para obtener más ayuda sobre Angular CLI, usa `ng help` o consulta la página [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli).

## API de C#

### Descripción

La API de C# (ArithmeticAPI) proporciona endpoints para realizar operaciones aritméticas.

### Requisitos

* .NET 8 SDK instalado.

### Ejecución de la API

1.  Navega al directorio `ArithmeticAPI/`.
2.  Ejecuta `dotnet run` para iniciar la API.
3.  La API estará disponible en `http://localhost:5000` (o el puerto configurado).

### Endpoints

* `/api/sum/{num1}/{num2}`: Suma dos números.
* `/api/subtract/{num1}/{num2}`: Resta dos números.
* `/api/multiply/{num1}/{num2}`: Multiplica dos números.
* `/api/divide/{num1}/{num2}`: Divide dos números.

### Interacción con Angular

La aplicación Angular utiliza los endpoints de la API para realizar operaciones aritméticas. Asegúrate de que la API esté en ejecución antes de usar la aplicación Angular.

## Configuración

* Asegúrate de que la URL de la API en la aplicación Angular esté configurada correctamente para apuntar a la API de C#.
* Si estás usando variables de entorno para la URL de la API, configúralas adecuadamente.

## Dependencias

* Asegúrate de ejecutar `npm install` en el directorio `arithmetic-app/` para instalar las dependencias de Angular.
* Asegúrate de tener el SDK de .NET 8 instalado para ejecutar la API de C#.
