using System;

class Program
{
    static double notaMinima = 11;

    static void Main(string[] args)
    {
        Console.Write("Ingrese la nota 1: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la nota 2: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la nota 3: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double promedio = CalcularPromedio(nota1, nota2, nota3);

        string estado = VerificarEstado(promedio);

        Console.WriteLine("\n--- REPORTE ---");
        Console.WriteLine("Promedio: " + promedio.ToString("F2"));
        Console.WriteLine("Estado: " + estado);

        Console.ReadKey();
    }

    static double CalcularPromedio(double n1, double n2, double n3)
    {
        return (n1 + n2 + n3) / 3;
    }

    static string VerificarEstado(double promedio)
    {
        if (promedio >= notaMinima)
        {
            return "Aprobado";
        }
        else
        {
            return "Desaprobado";
        }
    }
}