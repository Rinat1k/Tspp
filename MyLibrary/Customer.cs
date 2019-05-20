using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Customer
    {
        public int num { get;set; }
        public string name { get; set; }
        Customer(int num,string name)
        {
            this.num = num;
            this.name = name;
        }
       // public int ViewCatalog(BookCatalog obj);
       // public int TakeBook(ref BookCatalog _book, Worker _worker);
       // public int ReturnBook(ref BookCatalog book, Worker _worker);
       // public void ShowInfCustomer();
       // public void SetInfCustomer();
    }
}
