using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Book
    {
        public DateTime year {  get; set; }
        public string nameAuthor { get;  set; }
        public string title {  get;  set; }
        public string state {  get; set; }
        public Book(DateTime _year, string _nameAuthor, string _title, string _state)
        {
            this.year = _year;
            this.nameAuthor = _nameAuthor;
            this.title = _title;
            this.state = _state;
        }
       // public int SetInfBook();
       // public int ShowInfBook();
    }
}
