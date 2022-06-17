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
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Take_Order t = new Take_Order();
            t.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewItem v = new ViewItem();
            v.Show();
            Close();
        }
    }
}
