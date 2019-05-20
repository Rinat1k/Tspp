using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
namespace LibraryConsole
{
    class Program
    {
        public int total = 0;
        static void Main(string[] args)
        {
            int chooseKey = 0;
            BookCatalog _bookObj = new BookCatalog();
            IssueList _issueList = new IssueList();
            Customer customer = new Customer();
            Worker worker = new Worker();
            while (true)
            {
                Console.WriteLine("+++++++++++++++++++++++++");
                Console.WriteLine("Выберите роль: ");
                Console.WriteLine("1 - Работник");
                Console.WriteLine("2 - Клиент");
                Console.WriteLine("0 - Выход из программы");
                Console.WriteLine("+++++++++++++++++++++++++");
                chooseKey = Convert.ToInt16(Console.ReadLine());
                while (true)
                {
                    switch (chooseKey)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите функцию выбранной роли: ");
                                Console.WriteLine("1 - Просмотреть каталог");
                                Console.WriteLine("2 - Отсортировать каталог");
                                Console.WriteLine("3 - Добавить в каталог книгу");
                                Console.WriteLine("0 - Выйти в главное меню");
                                chooseKey = Convert.ToInt16(Console.ReadLine());
                                switch (chooseKey)
                                {
                                    case 1: worker.ViewCatalog(ref _bookObj); break;
                                    case 2: worker._books.Sort(); break;
                                    case 3: worker.AddBook(); break;
                                    case 0: break;
                                }
                            }
                            break;
                        //case 2: TODO
                        case 0: return;
                    }
                }
            }
        }
    }
}
