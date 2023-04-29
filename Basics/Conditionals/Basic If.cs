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
            bool isMale = false;
            bool isTall = false;


            //AND
            if (isMale && isTall)
            {
                Console.WriteLine("You are a Tall Male");
            }
            else 
            {
                Console.WriteLine("You are not Male or not Tall or Both");
            }

            Console.WriteLine();

            //OR
            if (isMale || isTall)
            {
                Console.WriteLine("You either a Male or a Tall person");
            }
            else
            {
                Console.WriteLine("You are not Male or not Tall or Both");
            }

            Console.WriteLine();

            //ELSE IF
            if (isMale && isTall)
            {
                Console.WriteLine("You are a Tall Male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a Short Male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a Tall Person");
            }
            else 
            {
                Console.WriteLine("You are not Male and not Tall");
            }
            Console.ReadLine();
        }

    }

}

