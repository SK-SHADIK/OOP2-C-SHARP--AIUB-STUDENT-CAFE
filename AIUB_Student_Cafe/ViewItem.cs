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
    public partial class ViewItem : Form
    {
        public ViewItem()
        {
            InitializeComponent();
        }

        private void viewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
        }
    }
}
