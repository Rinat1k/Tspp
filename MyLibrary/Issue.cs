using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Issue
    {
        public int issueID { get; set; }
        public int CustomerID { get; set; }
        public int WorkerID { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual Customer Customer { get; set; }
        /*public Customer objCustomer { get; set; }
        public DateTime date { get;  set; }
        public Worker objWorker {  get;  set; }*/
        
    }
}
