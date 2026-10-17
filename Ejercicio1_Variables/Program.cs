using System;

namespace Ejercicio1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ejercicio 1: Declaración e impresión de variables con distintos tipos de datos ===");
            
            // Tipos enteros
            int edad = 25;
            long poblacionMundial = 8000000000L;
            short temperatura = -5;
            byte nivelBateria = 85;

            // Tipos de punto flotante y decimal
            float altura = 1.75f;
            double pi = 3.14159265359;
            decimal precioProducto = 199.99m;

            // Tipo booleano
            bool esEstudiante = true;

            // Tipo caracter y cadena
            char inicial = 'A';
            string nombre = "Alejandro";

            // Impresión de variables
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Inicial: {inicial}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Población mundial estimada: {poblacionMundial}");
            Console.WriteLine($"Temperatura actual: {temperatura} °C");
            Console.WriteLine($"Nivel de batería: {nivelBateria}%");
            Console.WriteLine($"Altura: {altura} m");
            Console.WriteLine($"Valor de Pi: {pi}");
            Console.WriteLine($"Precio del producto: ${precioProducto}");
            Console.WriteLine($"¿Es estudiante?: {esEstudiante}");
        }
    }
}
