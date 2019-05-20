using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MyLibrary
{

    public class Customer
    {
        public int num { get; set; }
        public BookCatalog _books { get; set; }
        public string name;
        public void ViewCatalog(ref BookCatalog obj) => obj.ShowListBook();
        public int TakeBook( ref BookCatalog _books, ref Worker _worker,ref IssueList _issueList)
        {
            Book newBook = new Book();
            Console.WriteLine("Введите пожалуйста информацию о книге: ");
            newBook.SetInfBook();
            for (int i = 0; i < _books.book.Count; i++)
            {
                if (newBook == _books.book[i])
                {
                    _books.book[i].state = "Списана";
                    this._books.book.Add(_books.book[i]);
                    _issueList.AddListIssue(new Issue(_books.book[i].nameAuthor, this.name, this.num, DateTime.Now, _worker.name));
                }
            }
            return 0;
        }
        public int ReturnBook(ref Book book, ref Worker _worker)
        {
            _worker.RetBook(ref book);
            _books.book.Remove(book);
            return 0;
        }
        public void ShowInfCustomer() { return; }
        public void SetInfCustomer()
        {
            return;
        }
}
}
