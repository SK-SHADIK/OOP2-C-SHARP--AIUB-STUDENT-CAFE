using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIUB_Student_Cafe
{
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }

        private void viewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewItem v = new ViewItem();
            v.Show();
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Iteam have been added.");
        }
    }
}
