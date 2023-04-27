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
            Console.WriteLine( 40 );

            //basic int math
            Console.WriteLine(10 + 10);
            Console.WriteLine(10 - 10);
            Console.WriteLine(10 * 10);
            Console.WriteLine(10 / 10);
            Console.WriteLine(10 % 8);

            Console.WriteLine();

            //basic deci math
            Console.WriteLine(0.2 + 9.9);
            Console.WriteLine(10 - 0.1);
            Console.WriteLine(0.5 * 0.5);
            Console.WriteLine(2.2 / 2.1);
            Console.WriteLine(10.5 % 3.5);

            Console.WriteLine();

            int num = 1;
            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);

            Console.WriteLine();

            //methods
            Console.WriteLine( Math.Abs(-40) );
            Console.WriteLine( Math.Pow(3,2) );
            Console.WriteLine( Math.Sqrt(36) );
            Console.WriteLine( Math.Max(4, 90) );
            Console.WriteLine( Math.Min(4, 90) );
            Console.WriteLine( Math.Round(4.4) );
            Console.WriteLine( Math.Round(4.7) );

            Console.ReadLine();
        }
    }

}

