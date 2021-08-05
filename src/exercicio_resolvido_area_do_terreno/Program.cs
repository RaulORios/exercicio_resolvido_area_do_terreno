using System;
using System.Globalization;

namespace exercicio_resolvido_area_do_terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura;
            double comprimento;
            double precometroquadrado;
            double area;
            double preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precometroquadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precometroquadrado;

            Console.WriteLine();

            Console.WriteLine($"Area = {area.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Preço = {preco.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }
    }
}
