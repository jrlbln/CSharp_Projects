 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Book
    {
        public String title;
        public String author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages) 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

    }
}
