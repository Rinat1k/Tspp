using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class Worker
    {
        private BookCatalog _books;
        private string name;
        public int ViewCatalog();
        public int WriteOffBook(Book _book);
        public int IssueBook(Book _book, Customer _person);
        public void SetInfWorker();
        public void ShowInfWorker();
    }
}
