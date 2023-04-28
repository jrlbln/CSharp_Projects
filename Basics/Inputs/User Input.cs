using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Whole umber
            Console.Write("Enter 1st number : ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            int int2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(int1 + int2);

            Console.WriteLine();

            //Decimal
            Console.Write("Enter 1st number : ");
            double doub1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            double doub2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(doub1 + doub2);

            Console.ReadLine();
        }
    }

}

