using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class Book : Doccument
    {
        private string author;
        private int pages;

        public Book(string id, string publisher, int quantity, string author, int pages) : base(id, publisher,quantity)
        {
            this.author = author;
            this.pages = pages;
        }

        public string getAuthor()
        {
            return this.author;
        }
        public int getPage()
        {
            return this.pages;
        }
    }
}
