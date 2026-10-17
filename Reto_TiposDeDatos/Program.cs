using System;

namespace Reto_TiposDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Reto: Tipos de Datos en C# ===");

            // 1. Conversión implícita (Widening conversion)
            int numeroEntero = 42;
            long numeroLargo = numeroEntero; // implícito de int a long
            float numeroFlotante = numeroEntero; // implícito de int a float

            Console.WriteLine($"1. Conversión Implícita:");
            Console.WriteLine($"   int: {numeroEntero} -> long: {numeroLargo} -> float: {numeroFlotante}");

            // 2. Conversión explícita (Casting / Narrowing conversion)
            double valorDoble = 99.99;
            int enteroTruncado = (int)valorDoble; // casting explícito perdiendo decimales

            Console.WriteLine($"\n2. Conversión Explícita (Casting):");
            Console.WriteLine($"   double original: {valorDoble} -> int truncado: {enteroTruncado}");

            // 3. Conversión usando métodos de la clase Convert y Parse
            string cadenaNumero = "12345";
            int numeroConvertido = Convert.ToInt32(cadenaNumero);
            int numeroParseado = int.Parse(cadenaNumero);

            Console.WriteLine($"\n3. Conversión desde String (Convert y Parse):");
            Console.WriteLine($"   String: \"{cadenaNumero}\"");
            Console.WriteLine($"   Convert.ToInt32: {numeroConvertido} (Tipo: {numeroConvertido.GetType().Name})");
            Console.WriteLine($"   int.Parse: {numeroParseado} (Tipo: {numeroParseado.GetType().Name})");

            // 4. Uso seguro con TryParse
            string entradaInvalida = "abc123";
            bool exito = int.TryParse(entradaInvalida, out int resultadoParseo);

            Console.WriteLine($"\n4. Conversión Segura con TryParse:");
            Console.WriteLine($"   Intentando convertir \"{entradaInvalida}\" a entero: {exito}");
            if (!exito)
            {
                Console.WriteLine($"   La conversión falló de forma segura. Valor por defecto de salida: {resultadoParseo}");
            }

            // 5. Tipo nullable y tipos implícitos (var)
            var mensajeDinamico = "Esto es una variable con tipado implícito (var)";
            int? edadOpcional = null; // Tipo nullable

            Console.WriteLine($"\n5. Tipado implícito (var) y Nullable:");
            Console.WriteLine($"   var: {mensajeDinamico} [Tipo: {mensajeDinamico.GetType().Name}]");
            Console.WriteLine($"   int? (con valor null): {(edadOpcional.HasValue ? edadOpcional.Value.ToString() : "Sin valor asignado")}");
            
            edadOpcional = 30;
            Console.WriteLine($"   int? (asignado): {edadOpcional.Value}");
        }
    }
}
