using System;

namespace BoletaVenta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BOLETA DE VENTA ===");

            Console.Write("Ingrese la cantidad comprada: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el precio unitario: S/ ");
            double precioUnitario = Convert.ToDouble(Console.ReadLine());

            double subtotal = CalcularSubtotal(cantidad, precioUnitario);
            double igv = CalcularIGV(subtotal);
            double total = CalcularTotal(subtotal, igv);

            Console.WriteLine("\n===== BOLETA =====");
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("Precio Unitario: S/ " + precioUnitario.ToString("F2"));
            Console.WriteLine("Subtotal: S/ " + subtotal.ToString("F2"));
            Console.WriteLine("IGV (18%): S/ " + igv.ToString("F2"));
            Console.WriteLine("Total a pagar: S/ " + total.ToString("F2"));

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }

        static double CalcularSubtotal(int cantidad, double precioUnitario)
        {
            return cantidad * precioUnitario;
        }

        static double CalcularIGV(double subtotal)
        {
            return subtotal * 0.18;
        }

        static double CalcularTotal(double subtotal, double igv)
        {
            return subtotal + igv;
        }
    }
}