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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void работникToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьРаботникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void просмотретьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listBook = new ListBook();
            listBook.Show();
        }

        private void посмотретьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listIssue = new ListIssue();
            listIssue.Show();
        }
    }
}
