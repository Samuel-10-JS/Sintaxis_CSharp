using System;

namespace Reto_TiposDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables según el reto
            int age = 25;
            double height = 1.75;
            bool is_student = true;
            string name = "Ana";
            char grade = 'A';

            // Impresión en consola con mensajes descriptivos
            Console.WriteLine($"La edad es: {age}");
            Console.WriteLine($"La altura es: {height}");
            Console.WriteLine($"¿Es estudiante?: {is_student}");
            Console.WriteLine($"El nombre es: {name}");
            Console.WriteLine($"La calificación es: {grade}");
        }
    }
}
