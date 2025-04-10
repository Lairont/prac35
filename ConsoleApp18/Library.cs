using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp18
{
    internal class Library
    {

        List<FictionBook> fictionBooks = new List<FictionBook>();
        List<NonFictionBook> nonFictionBooks = new List<NonFictionBook>();
        List<TextBook> textBooks = new List<TextBook>();
       
        public void AddFictionBook()
        {
            int year = 0, price = 0;
            string title = "", author = "", genre = "";
            Console.Write("Название: ");
            try
            {
                title = Console.ReadLine();
            }
            catch { }
            Console.Write("Автор: ");
            try
            {
                author = Console.ReadLine();
            }
            catch { }
            Console.Write("Год издания: ");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.Write("Цена: ");
            try
            {
                price = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.Write("Жанр: ");
            try
            {
                genre = Console.ReadLine();
            }
            catch { }
            fictionBooks.Add(new FictionBook(title, author, year, price, genre));
        }

        public void AddNonFictionBook()
        {
            int year = 0, price = 0;
            string title = "", author = "", subject = "";
            Console.Write("Название: ");
            try
            {
                title = Console.ReadLine();
            }
            catch { }
            Console.Write("Автор: ");
            try
            {
                author = Console.ReadLine();
            }
            catch { }
            Console.Write("Год издания: ");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.Write("Цена: ");
            try
            {
                price = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.Write("Предмет: ");
            try
            {
                subject = Console.ReadLine();
            }
            catch { }
            nonFictionBooks.Add(new NonFictionBook(title, author, year, price, subject));
        }
        public void AddTextBook()
        {
            int year = 0, price = 0;
            string title = "", author = "", grade_level = "";
            Console.Write("Название: ");
            try
            {
               title = Console.ReadLine();
            }
            catch { }
            Console.Write("Автор: ");
            try
            {
               author = Console.ReadLine();
            }
            catch { }
            Console.Write("Год издания: ");
            try
            {
              year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.Write("Цена: ");
            try
            {
              price = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.Write("Уровень обучения: ");
            try
            {
              grade_level = Console.ReadLine();
            }
            catch { }
            textBooks.Add(new TextBook(title, author, year, price, grade_level));
        }
        
        public void GetAllFictionBooks()
        {
            foreach (FictionBook fBook in fictionBooks)
            {
                Console.WriteLine($"\nНазвание: {fBook.Title}\nАвтор: {fBook.Author}\nГод издания: {fBook.Year}\nЦена: {fBook.Price}\nЖанр: {fBook.Genre}");
            }
        }
        public void GetAllNonFictionBooks()
        {
            foreach (NonFictionBook fBook in nonFictionBooks)
            {
                Console.WriteLine($"\nНазвание: {fBook.Title}\nАвтор: {fBook.Author}\nГод издания: {fBook.Year}\nЦена: {fBook.Price}\nПредмет: {fBook.Subject}");
            }
        }
        public void GetAllTextBooks()
        {
            foreach (TextBook tBook in textBooks)
            {
                Console.WriteLine($"\nНазвание: {tBook.Title}\nАвтор: {tBook.Author}\nГод издания: { tBook.Year}\nЦена: {tBook.Price}\nУровень обучения: {tBook.Grade_level}");
            }
        }
    }
}
