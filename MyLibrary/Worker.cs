using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class Worker
    {
        public BookCatalog _books { get; set; }
        public string name {  get; set; }
        public int ViewCatalog();
        public int WriteOffBook(Book _book);
        public int IssueBook(Book _book, Customer _person);
        public void SetInfWorker();
        public void ShowInfWorker();
    }
}
