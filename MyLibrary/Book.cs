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
        public int SetInfBook();
        public int ShowInfBook();
    }
}
