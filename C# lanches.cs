using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cachorro quente: Cod 1");
            Console.WriteLine("X-salada: Cod 2");
            Console.WriteLine("X-bacon: Cod 3");
            Console.WriteLine("Torrada Simples: Cod 4");
            Console.WriteLine("Refrigerante: Cod 5");

            Console.WriteLine("Informe o código do seu produto:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos você quer? ");
            int quantidade = int.Parse(Console.ReadLine());

            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.00;
            }
            
            else if (codigo == 2)
            {
                total = quantidade * 4.50;
            }

            else if (codigo == 3)
            {
                total = quantidade * 5.00;
            }

            else if (codigo == 4)
            {
                total = quantidade * 2.00;
            }

            else if (codigo == 5 )
            {
                total = quantidade * 1.00;
            }
            else
            {
                total = 0.00;
            }

            Console.WriteLine($"Total: R$ {total:F2}");

        }
    }
}
