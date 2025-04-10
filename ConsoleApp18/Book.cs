using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    abstract class Book
    {
        protected string title, author;
        protected int year, price;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Year 
             {
            get { return year; }
            set { if (value <= DateTime.Today.Year) year = value; }
        }
        public int Price
        {
            get { return price; }
            set { if (value > 0) price = value; }
        }

        public Book() { }
        public Book(string title, string author, int year, int price)
        {
            Title = title;
            Author = author;
            Year = year;
            Price = price;
        }
    }
}
