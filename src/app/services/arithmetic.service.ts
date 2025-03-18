// Importa el decorador Injectable para declarar un servicio inyectable en Angular
import { Injectable } from '@angular/core';
// Importa HttpClient para hacer peticiones HTTP al backend
import { HttpClient } from '@angular/common/http';
// Importa Observable para trabajar con peticiones asincrónicas
import { Observable } from 'rxjs';

// Decorador que indica que este servicio está disponible en toda la aplicación (root)
@Injectable({
  providedIn: 'root'
})
export class ArithmeticService {
  // URL base del backend API donde se encuentran los endpoints de operaciones
  private apiUrl = 'https://localhost:7151/api/Arithmetic'; // Asegúrate de que esta URL sea correcta según tu backend

  // Inyecta HttpClient en el constructor para hacer solicitudes HTTP
  constructor(private http: HttpClient) { }

  /**
   * Método genérico que llama a un endpoint según la operación (sum, subtract, etc.)
   * @param num1 Primer número
   * @param num2 Segundo número
   * @param operation Tipo de operación ('sum', 'subtract', 'multiply', 'divide')
   * @returns Un Observable con el resultado numérico
   */
  calculate(num1: number, num2: number, operation: string): Observable<number> {
    let url = `${this.apiUrl}/${operation}?num1=${num1}&num2=${num2}`; // Construye la URL dinámica
    return this.http.get<number>(url); // Realiza la petición GET al backend
  }

  /**
   * Método para sumar dos números
   * @param num1 Primer número
   * @param num2 Segundo número
   * @returns Observable con el resultado de la suma
   */
  sum(num1: number, num2: number): Observable<number> {
    return this.http.get<number>(`${this.apiUrl}/sum?num1=${num1}&num2=${num2}`);
  }

  /**
   * Método para restar dos números
   * @param num1 Primer número
   * @param num2 Segundo número
   * @returns Observable con el resultado de la resta
   */
  subtract(num1: number, num2: number): Observable<number> {
    return this.http.get<number>(`${this.apiUrl}/subtract?num1=${num1}&num2=${num2}`);
  }

  /**
   * Método para multiplicar dos números
   * @param num1 Primer número
   * @param num2 Segundo número
   * @returns Observable con el resultado de la multiplicación
   */
  multiply(num1: number, num2: number): Observable<number> {
    return this.http.get<number>(`${this.apiUrl}/multiply?num1=${num1}&num2=${num2}`);
  }

  /**
   * Método para dividir dos números
   * @param num1 Primer número
   * @param num2 Segundo número
   * @returns Observable con el resultado de la división
   */
  divide(num1: number, num2: number): Observable<number> {
    return this.http.get<number>(`${this.apiUrl}/divide?num1=${num1}&num2=${num2}`);
  }
}
