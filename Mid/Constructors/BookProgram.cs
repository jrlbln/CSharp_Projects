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
            
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
            Console.WriteLine();
            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

        }

    }

}
