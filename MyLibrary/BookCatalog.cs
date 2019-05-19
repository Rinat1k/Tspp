using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class BookCatalog
    {
        private List<Book> book;
        public int SearchBook(Book _book);
        public int Sort();
        public int AddBook(Book _book);
        public int DeleteBook(Book _book);
    }
}
