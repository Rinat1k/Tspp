using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
namespace LibraryUI
{
    public partial class ListBook : Form
    {
        BookCatalog books = new BookCatalog();
        public ListBook()
        {
            InitializeComponent();
        }
       
    }
}
