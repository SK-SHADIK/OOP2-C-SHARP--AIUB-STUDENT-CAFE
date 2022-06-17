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
    public partial class Take_Order : Form
    {
        public Take_Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewItem v = new ViewItem();
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
