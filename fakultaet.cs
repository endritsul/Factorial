using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakultätVonN
{
    class Program
    {
        static void Main(string[] args)
        {

            int zahl;
            int result = 1;
            string streingabe;

            Console.WriteLine("Zahl eingeben");
            streingabe = Console.ReadLine();
            zahl = Convert.ToInt32(streingabe);

            for (int i = 1; i<=zahl; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);

            Console.ReadLine();
        }


    }
}