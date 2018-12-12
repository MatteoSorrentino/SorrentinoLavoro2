using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversioni2
{
    class Program
    {
        static void Main(string[] args)
        {
            string risultato = "";
            int num = 0;
            Console.WriteLine("Inserisci il numero da convertire");
            num = Convert.ToInt32(Console.ReadLine());
            int num2 = num;

            while (num > 1)
            {
                int resto = num % 2;
                risultato = Convert.ToString(resto) + risultato;
                num = num / 2;
            }
            risultato = Convert.ToString(num) + risultato;
            Console.WriteLine($"il numero binario è {risultato}");

            Console.WriteLine("inserisci la base");
            int valbase = Convert.ToInt32(Console.ReadLine());
            while (valbase!=16 || valbase !=8)
            {
                Console.WriteLine("base non opportuna, rinserisci");
                valbase = Convert.ToInt32(Console.ReadLine());
            }
            string risultato2 = "";

            while (num2 > 0)
            {
                int resto = num2 % valbase;
                risultato2 = Convert.ToString(resto, valbase) + risultato2;
                num2 = num2 / valbase;
            }
            Console.WriteLine($"Il numero convertito in {valbase} è uguale a {risultato2}");

            Console.ReadLine();
        }
    }
}
