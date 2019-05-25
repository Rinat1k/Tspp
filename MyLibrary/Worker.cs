using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Worker
    {
        public int IssueID {get;set; }
        public int WorkerID { get; set; }
        public string name { get; private set; }
        public virtual ICollection<Issue> issues { get; set; }
        public override string ToString()
        {
            return $"№{IssueID} от {ToIssue.ToString("dd.MM.yy hh:mm:ss")}";
        }
        public DateTime ToIssue { get; set; }
        /*Worker()
        {
            this.name = "Лев Львович";
        }*/
        //public int ViewCatalog()
        //  public int WriteOffBook(Book _book);
        // public int IssueBook(Book _book, Customer _person);
        // public void ShowInfWorker();
    }
}
