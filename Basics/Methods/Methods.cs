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
            SayHi("Tom" , 33);
            SayHi("Joe" , 56);
            SayHi("Mike" , 12);

            Console.ReadLine();
        }

        static void SayHi(string name, int age) 
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old ");
        }
    }

}

