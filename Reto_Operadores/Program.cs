using System;

namespace Reto_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Declaracion de variables iniciales
            int width = 7;
            int height = 5;

            // 2. Calculo del área inicial
            int area = width * height;

            // 3. Calculo del perimetro inicial
            int perimeter = (2 * width) + (2 * height);

            Console.WriteLine($"Dimensiones iniciales -> Ancho: {width}, Alto: {height}");
            Console.WriteLine($"Área inicial: {area}");
            Console.WriteLine($"Perímetro inicial: {perimeter}\n");

            // 4. Incrementar width en 3 unidades usando asignación compuesta
            width += 3;

            // 5. Disminucion height en 2 unidades usando asignación compuesta
            height -= 2;

            // 6. Recalcular área y perímetro con las nuevas dimensiones
            area = width * height;
            perimeter = (2 * width) + (2 * height);

            // 7. Mostrar valores finales por consola
            Console.WriteLine("--- Valores Finales ---");
            Console.WriteLine($"Ancho final (width): {width}");
            Console.WriteLine($"Alto final (height): {height}");
            Console.WriteLine($"Área final (area): {area}");
            Console.WriteLine($"Perímetro final (perimeter): {perimeter}");
        }
    }
}
