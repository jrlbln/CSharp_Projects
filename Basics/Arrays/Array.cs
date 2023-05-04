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
            int[] luckyNumbers = { 4,8,15,16,23,42 };
            string[] friends = new string[5];

            friends[0] = "Jim";
            friends[1] = "Kelly";
            friends[2] = "Joe";
            friends[3] = "Sam";
            friends[4] = "John";

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(friends[2]);
            Console.ReadLine();
        }
    }

}

