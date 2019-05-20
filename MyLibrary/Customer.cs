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
        public void ViewCatalog(BookCatalog obj) => obj.ShowListBook();
        public int TakeBook(ref Book _book, ref Worker _worker,ref IssueList _issueList)
        {
            _books.book.Add(_book);
            _worker.WriteOffBook(ref _book);
            _issueList.AddListIssue(new Issue(_book.nameAuthor,this.name,this.num,DateTime.Now,_worker.name));
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
            Console.WriteLine("Введите информацию о клиенте: ");
            name = Console.ReadLine();
            //num++;
            return;
        }
}
}
