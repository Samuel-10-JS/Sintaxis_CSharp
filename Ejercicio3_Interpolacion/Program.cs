using System;

namespace Ejercicio3_Interpolacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ejercicio 3: Mostrar resultados usando interpolación de strings ===");

            string producto = "Laptop Gamer";
            decimal precioUnitario = 1250.50m;
            int cantidad = 2;
            decimal subtotal = precioUnitario * cantidad;
            decimal descuento = subtotal * 0.10m; // 10% de descuento
            decimal totalPagar = subtotal - descuento;
            bool esClienteFrecuente = true;

            // Uso avanzado de interpolación de strings con formato y expresiones en línea
            Console.WriteLine($@"
----------------------------------------
          FACTURA DE COMPRA
----------------------------------------
Producto:         {producto}
Precio Unitario:  {precioUnitario:C2}
Cantidad:         {cantidad}
Subtotal:         {subtotal:C2}
Descuento (10%):  {descuento:C2}
Total a Pagar:    {totalPagar:C2}
Cliente Frecuente:{(esClienteFrecuente ? "Sí (Aplica beneficio adicional)" : "No")}
----------------------------------------
Fecha de emisión: {DateTime.Now:dd/MM/yyyy HH:mm:ss}
");
        }
    }
}
