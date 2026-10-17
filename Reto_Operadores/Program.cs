using System;

namespace Reto_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Reto: Operadores Avanzados en C# ===");

            // Escenario: Evaluación de elegibilidad para un crédito preferencial y cálculo de bonificación
            string nombreCliente = "Sofía Martínez";
            decimal salarioMensual = 3500.00m;
            int aniosExperienciaLaboral = 4;
            int historialCrediticioPuntaje = 720; // Escala de 0 a 850
            bool tieneDeudasPendientes = false;

            Console.WriteLine($"Cliente: {nombreCliente}");
            Console.WriteLine($"Salario Mensual: {salarioMensual:C2}");
            Console.WriteLine($"Años de Experiencia: {aniosExperienciaLaboral}");
            Console.WriteLine($"Puntaje Crediticio: {historialCrediticioPuntaje}");
            Console.WriteLine($"¿Tiene deudas pendientes?: {tieneDeudasPendientes}\n");

            // 1. Operadores relacionales y lógicos
            // Requisitos: Salario >= 3000 O Años de Experiencia >= 5, Y Puntaje Crediticio >= 700, Y Sin deudas pendientes.
            bool cumpleIngresoOExperiencia = (salarioMensual >= 3000.00m) || (aniosExperienciaLaboral >= 5);
            bool cumpleHistorial = historialCrediticioPuntaje >= 700;
            bool sinDeudas = !tieneDeudasPendientes;

            bool esAptoParaCredito = cumpleIngresoOExperiencia && cumpleHistorial && sinDeudas;

            // 2. Operador condicional (ternario)
            string estadoCredito = esAptoParaCredito ? "APROBADO PARA CRÉDITO PREFERENCIAL" : "RECHAZADO";

            Console.WriteLine("--- Resultado de Evaluación ---");
            Console.WriteLine($"Estado del crédito: {estadoCredito}");

            // 3. Operadores de incremento y decremento
            int intentosEvaluacion = 1;
            Console.WriteLine($"\nIntentos de evaluación registrados: {intentosEvaluacion}");
            intentosEvaluacion++; // Incremento posterior
            Console.WriteLine($"Intentos después de procesar solicitud (++): {intentosEvaluacion}");

            // 4. Cálculos aritméticos y de asignación compuestos para bonificación y tasa de interés
            decimal tasaInteres = 12.5m; // 12.5%
            Console.WriteLine($"\nTasa de interés base: {tasaInteres}%");

            if (esAptoParaCredito)
            {
                // Si es excelente cliente (puntaje > 750), se reduce la tasa con operador de asignación compuesto (-=)
                if (historialCrediticioPuntaje > 750)
                {
                    tasaInteres -= 2.0m; // Descuento por excelente historial
                    Console.WriteLine("¡Bonificación aplicada! Descuento de 2.0% por excelente historial.");
                }
                else
                {
                    tasaInteres -= 1.5m; // Descuento estándar por aprobación
                    Console.WriteLine("Descuento estándar de 1.5% aplicado por aprobación.");
                }
            }
            else
            {
                tasaInteres += 3.0m; // Recargo por riesgo
                Console.WriteLine("Recargo de 3.0% aplicado por riesgo crediticio.");
            }

            Console.WriteLine($"Tasa de interés final asignada: {tasaInteres}%");
        }
    }
}
