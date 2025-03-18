using Microsoft.AspNetCore.Mvc; // Importa el espacio de nombres necesario para controladores API

namespace ArithmeticAPI.Controllers // Define el espacio de nombres del controlador
{
    [Route("api/[controller]")] // Define la ruta base para todos los endpoints en este controlador
                                // [controller] se reemplaza con "Arithmetic"
    [ApiController] // Marca la clase como un controlador API, habilitando características como validación automática
    public class ArithmeticController : ControllerBase // Define la clase del controlador, heredando de ControllerBase
    {
        // Endpoint para la operación de suma
        [HttpGet("sum")] // Define este método como un endpoint HTTP GET con ruta "/api/Arithmetic/sum"
        public IActionResult sum(int num1, int num2) // Define el método sum, que toma dos enteros como parámetros
        {
            // Realiza la suma de los dos números y devuelve un resultado OK (HTTP 200) con el resultado
            return Ok(num1 + num2);
        }

        // Endpoint para la operación de resta
        [HttpGet("subtract")] // Define este método como un endpoint HTTP GET con ruta "/api/Arithmetic/subtract"
        public IActionResult subtract(int num1, int num2) // Define el método subtract, que toma dos enteros como parámetros
        {
            // Realiza la resta de los dos números y devuelve un resultado OK (HTTP 200) con el resultado
            return Ok(num1 - num2);
        }

        // Endpoint para la operación de multiplicación
        [HttpGet("multiply")] // Define este método como un endpoint HTTP GET con ruta "/api/Arithmetic/multiply"
        public IActionResult multiply(int num1, int num2) // Define el método multiply, que toma dos enteros como parámetros
        {
            // Realiza la multiplicación de los dos números y devuelve un resultado OK (HTTP 200) con el resultado
            return Ok(num1 * num2);
        }

        // Endpoint para la operación de división
        [HttpGet("divide")] // Define este método como un endpoint HTTP GET con ruta "/api/Arithmetic/divide"
        public IActionResult divide(int num1, int num2) // Define el método divide, que toma dos enteros como parámetros
        {
            // Verifica si el segundo número es cero para evitar la división por cero
            if (num2 == 0)
            {
                // Si el segundo número es cero, devuelve un resultado BadRequest (HTTP 400) con un mensaje de error
                return BadRequest("No se puede dividir por cero.");
            }

            // Realiza la división de los dos números, convirtiendo el resultado a double para obtener decimales
            // y devuelve un resultado OK (HTTP 200) con el resultado
            return Ok((double)num1 / num2);
        }
    }
}