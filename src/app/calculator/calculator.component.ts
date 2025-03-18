// Importa el decorador Component para definir un componente de Angular
import { Component } from '@angular/core';
// Importa el servicio personalizado que realiza las operaciones aritméticas
import { ArithmeticService } from '../services/arithmetic.service';
// Importa para manejar errores HTTP en la suscripción del observable
import { HttpErrorResponse } from '@angular/common/http';
// Importa CommonModule (necesario para directivas como *ngIf, *ngFor)
import { CommonModule } from '@angular/common';
// Importa FormsModule para permitir el uso de [(ngModel)] en el template
import { FormsModule } from '@angular/forms';

// Decorador que define el componente
@Component({
  selector: 'app-calculator', // Nombre del componente que se usa en el HTML
  standalone: true, // Permite que el componente sea independiente y use imports
  imports: [CommonModule, FormsModule], // Módulos necesarios para que funcione el template
  templateUrl: './calculator.component.html', // Ruta del archivo HTML del componente
  styleUrls: ['./calculator.component.css'] // Ruta del archivo CSS del componente
})
export class CalculatorComponent {
  // Variables enlazadas al formulario
  num1: number | null = null; // Primer número ingresado por el usuario
  num2: number | null = null; // Segundo número
  operation: string = 'sum';  // Operación seleccionada (por defecto suma)
  result: number | null = null; // Resultado de la operación
  error: string | null = null; // Mensaje de error en caso de fallo

  // Constructor que inyecta el servicio de operaciones aritméticas
  constructor(private arithmeticService: ArithmeticService) {}

  // Método que se ejecuta al enviar el formulario
  onSubmit() {
    // Validación: Verifica que ambos números estén ingresados
    if (this.num1 === null || this.num2 === null) {
      this.error = 'Por favor ingresa ambos números.';
      return; // Detiene la ejecución si falta un número
    }

    this.error = null; // Reinicia el mensaje de error si todo está bien

    // Llama al servicio para calcular el resultado y se suscribe al observable
    this.arithmeticService.calculate(this.num1, this.num2, this.operation).subscribe(
      (res: number) => {
        this.result = res; // Si todo sale bien, guarda el resultado
      },
      (err: HttpErrorResponse | any) => {
        this.error = 'Hubo un error con la operación.'; // Muestra mensaje de error
        console.error('Error:', err.message || err); // Imprime el error en consola
      }
    );
  }
}
