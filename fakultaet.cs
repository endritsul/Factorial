using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyOfN
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;
            int result = 1;
            string strGivenNumber;

            Console.WriteLine("... Type in a number");
            strGivenNumber = Console.ReadLine();
            number = Convert.ToInt32(strGivenNumber);

            for (int i = 1; i<=zahl; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);

            Console.ReadLine();
        }


    }
}
