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
    public partial class SignUpFor : Form
    {
        public SignUpFor()
        {
            InitializeComponent();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have succesfully creat a acoount \nThank you");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
