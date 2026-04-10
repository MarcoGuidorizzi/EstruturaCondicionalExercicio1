using System;
using System.Globalization;

namespace Est.CondicionalEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double soma;

            while (true) {
                Console.Write("Digite sua primeira nota: ");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite sua segunda nota: ");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                soma = nota1 + nota2;

                Console.WriteLine("Nota final = " + soma.ToString("F1", CultureInfo.InvariantCulture));
                if (soma >= 60.0)
                {
                    Console.WriteLine("APROVADO!");
                } 
                else{
                    Console.WriteLine("REPROVADO!");
                }

                Console.ReadLine();
            }
        }
    }
}