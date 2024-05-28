using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParametro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("informe o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());
            

            Console.WriteLine("O resultado da operação é: " + operação(n1, n2));
            Console.ReadKey();
        }
        static double operação(double n1, double n2)
        {
            Console.WriteLine("Informe a operação desejada [adição, subtração, multiplicação ou divisão]: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "adição":

                    return n1 + n2;                   

                case "subtração":

                    return n1 - n2;

                case "multiplicação":

                    return n1 * n2;

                case "divisão":

                    return n1 / n2;

                default: return 0;
            }
            
        }
       
    }
}
