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
            //Strings
            Console.WriteLine("Hello \n World");
            Console.WriteLine("Hello \" World");
            Console.WriteLine();

            //Concatination
            string phrase = "Hi " + "Earth";
            Console.WriteLine( phrase.Length );
            Console.WriteLine();

            //Method
            Console.WriteLine( phrase.ToUpper() ) ;
            Console.WriteLine( phrase.Contains("Hi") );
            Console.WriteLine( phrase[3] );
            Console.WriteLine( phrase.IndexOf("Earth"));
            Console.WriteLine( phrase.IndexOf('r') );
            Console.WriteLine( phrase.IndexOf('z'));
            Console.WriteLine( phrase.Substring(3));
            Console.WriteLine(phrase.Substring(3,3));
            Console.WriteLine();

            Console.ReadLine();
        }
    }

}

