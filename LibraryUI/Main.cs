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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void добавитьРаботникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void посмотретьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listIssue = new ListIssue();
            listIssue.Show();
        }

        private void взятьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void посмотретьКаталогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //работник 
        }

        private void посмотретьКаталогToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listBook = new ListBook();
            listBook.Show();
        }

        private void посмотретьКаталогToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var listBook = new ListBook();
            listBook.Show();
        }

        private void изменитьКаталогToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
