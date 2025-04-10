using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                int i = 0;
                Console.WriteLine("Выберите действие:\n" +
                    "1. Добавить в список учебник\n" +
                    "2. Добавить в список художественную книгу\n" +
                    "3. Добавить в список нехудожественную книгу\n" +
                    "4. Вывести все учебники\n" +
                    "5. Вывести все художественные книги\n" +
                    "6. Вывести все нехудожественные книги\n" +
                    "7. Выйти");
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
                switch (i)
                {
                    case 1: library.AddTextBook(); break;
                    case 2: library.AddFictionBook(); break;
                    case 3: library.AddNonFictionBook(); break;
                    case 4: library.GetAllTextBooks(); break;
                    case 5: library.GetAllFictionBooks(); break;
                    case 6: library.GetAllNonFictionBooks(); break;
                    case 7: return;
                }
                Console.WriteLine();
            }
        }
    }
}
