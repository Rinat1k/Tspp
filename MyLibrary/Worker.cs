using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Worker
    {
        public BookCatalog _books = new BookCatalog();
        public string name { get { string _name = "Работник Работникович"; return _name; } set {  } }
        public int ViewCatalog(ref BookCatalog _books) { _books.ShowListBook(); return 0; }
        public int WriteOffBook(ref Book _book)
        {
           _book.state = "Списана";
            return 0;
        }
        public int IssueBook(ref Book _book, Customer _person,ref IssueList _issueList)
        {
            _book.state = "Выдана";
            _issueList.AddListIssue(new Issue(this.name, _person.name, _person.num, DateTime.Now, _book.title));
            return 0;
        }
        public int AddBook() => _books.AddBook();
        public void ChangeNameWorker() => name = Console.ReadLine();
        public void RetBook(ref Book _book) => _book.state = "Свободная";
        //public void ShowInfWorker() { return ; }
    }
}
