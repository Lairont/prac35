using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class FictionBook : Book
    {
        string genre;

        public string Genre { get => genre; set => genre = value; }

        public FictionBook(string title, string author, int year,int price, string genre) : base(title, author, year, price)
            
        {
            Genre = genre;
        }
    }
}
