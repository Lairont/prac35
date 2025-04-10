using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class TextBook : Book
    {
        private string grade_level;

        public string Grade_level { get => grade_level; set => grade_level = value; }

        public TextBook(string title, string author, int year,int price, string grade_level) : base(title, author, year, price)
            
        {
            Grade_level = grade_level;
        }
    }
}
