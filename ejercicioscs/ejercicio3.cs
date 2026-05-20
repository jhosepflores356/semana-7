using System;

class Program
{
    static double CalcularBruto(double horas)
    {
        return horas * 12.50;
    }

    static double CalcularDescuento(double bruto)
    {
        return bruto * 0.05;
    }

    static double CalcularNeto(double bruto, double descuento)
    {
        return bruto - descuento;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese las horas trabajadas: ");
        double horas = Convert.ToDouble(Console.ReadLine());

        double sueldoBruto = CalcularBruto(horas);
        double descuento = CalcularDescuento(sueldoBruto);
        double sueldoNeto = CalcularNeto(sueldoBruto, descuento);

        Console.WriteLine("\n--- BOLETA DE SUELDO ---");
        Console.WriteLine("Sueldo bruto: S/ " + sueldoBruto.ToString("F2"));
        Console.WriteLine("Descuento (5%): S/ " + descuento.ToString("F2"));
        Console.WriteLine("Sueldo neto: S/ " + sueldoNeto.ToString("F2"));

        Console.ReadKey();
    }
}