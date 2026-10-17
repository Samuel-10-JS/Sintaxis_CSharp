using System;

namespace Ejercicio2_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ejercicio 2: Uso de operadores aritméticos y de asignación ===");

            // Operadores aritméticos básicos
            double num1 = 20.0;
            double num2 = 4.0;

            double suma = num1 + num2;
            double resta = num1 - num2;
            double multiplicacion = num1 * num2;
            double division = num1 / num2;
            double modulo = num1 % num2;

            Console.WriteLine($"Número 1: {num1}, Número 2: {num2}");
            Console.WriteLine($"Suma (+): {suma}");
            Console.WriteLine($"Resta (-): {resta}");
            Console.WriteLine($"Multiplicación (*): {multiplicacion}");
            Console.WriteLine($"División (/): {division}");
            Console.WriteLine($"Módulo (%): {modulo}");

            // Operadores de asignación
            Console.WriteLine("\n--- Operadores de Asignación ---");
            double puntuacion = 50.0;
            Console.WriteLine($"Puntuación inicial: {puntuacion}");

            puntuacion += 25; // Equivalente a puntuacion = puntuacion + 25
            Console.WriteLine($"Después de += 25: {puntuacion}");

            puntuacion -= 10; // Equivalente a puntuacion = puntuacion - 10
            Console.WriteLine($"Después de -= 10: {puntuacion}");

            puntuacion *= 2;  // Equivalente a puntuacion = puntuacion * 2
            Console.WriteLine($"Después de *= 2: {puntuacion}");

            puntuacion /= 4;  // Equivalente a puntuacion = puntuacion / 4
            Console.WriteLine($"Después de /= 4: {puntuacion}");

            puntuacion %= 3;  // Equivalente a puntuacion = puntuacion % 3
            Console.WriteLine($"Después de %= 3: {puntuacion}");
        }
    }
}
