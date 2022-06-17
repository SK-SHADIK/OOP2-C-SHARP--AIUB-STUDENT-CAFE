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
    public partial class Cafe_Inventory : Form
    {
        public Cafe_Inventory()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            Close();
        }
    }
}
