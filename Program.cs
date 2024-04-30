using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ArrayMes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio" };

            Console.WriteLine("Digite o número do mês que deseja de 0 a 4: ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("O mês escolhido foi: " + mes[i]);

            Console.ReadKey();
        }
    }
}
