﻿using System;
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
            char chooseKey;
            char chooseKey1;
            char chooseKey2='1';
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
                chooseKey = Convert.ToChar(Console.ReadLine());
                switch (chooseKey)
                {
                    case '1':
                        {
                                //Console.ReadKey();
                                //Console.Clear();
                                Console.WriteLine("Выберите функцию для работника: ");
                                Console.WriteLine("1 - Просмотреть каталог");
                                Console.WriteLine("2 - Отсортировать каталог");
                                Console.WriteLine("3 - Добавить в каталог книгу");
                                Console.WriteLine("4 - Посмотреть список выдач");
                                Console.WriteLine("0 - Выйти в главное меню");
                                chooseKey1 = Convert.ToChar(Console.ReadLine());
                                switch (chooseKey1)
                                {
                                    case '1': worker.ViewCatalog(ref _bookObj); break;
                                    case '2': worker._books.Sort(); break;
                                    case '3': _bookObj.AddBook();break;
                                    case '4': _issueList.ShowList();break;
                                    case '0':break;
                                }
                        }
                        break;
                    case '2':
                        {
                                //Console.ReadKey();
                                //Console.Clear();
                                Console.WriteLine("Выберите функцию для клиента:");
                                Console.WriteLine("1 - Просмотреть каталог библиотеки");
                                Console.WriteLine("2 - Просмотреть список взятых книг");
                                Console.WriteLine("3 - Взять книгу");
                                Console.WriteLine("4 - Возвратить книгу");
                                Console.WriteLine("0 - Выйти в главное меню");
                                chooseKey2 = Convert.ToChar(Console.ReadLine());
                                switch (chooseKey2)
                                {
                                    case '1': customer.ViewCatalog(ref _bookObj); break;
                                    case '2': customer._books.ShowListBook(); break;
                                    case '3': customer.TakeBook(ref _bookObj, ref worker, ref _issueList); break;
                                    case '4':customer.ReturnBook(ref worker,ref _bookObj); break;
                                    case '0':break;
                                }
                            }
                        break;
                    case '0': return;
                }
            }
        }
    }
}
