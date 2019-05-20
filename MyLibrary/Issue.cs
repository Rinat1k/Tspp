using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Issue
    {
        public Book objBook { get; set; }
        public Customer objCustomer { get; set; }
        public DateTime date { get;  set; }
        public Worker objWorker {  get;  set; }
    }
}
