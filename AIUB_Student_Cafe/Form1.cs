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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {

            if (NameSI.Text == "")
            {
                n.Text = "Enter Your Name";
            }
            else if (PassSI.Text == "")
            {
                n.Text = "Enter Your password";
            }
            else
            {
                if (NameSI.Text != "s" && PassSI.Text != "1")
                {
                    n.Text = "Invalid Name And Password";
                }
                if (NameSI.Text == "s" && PassSI.Text != "1")
                {
                    n.Text = "Invalid Password";
                }
                if (NameSI.Text != "s" && PassSI.Text == "1")
                {
                    n.Text = "Invalid Name ";
                }

                if (NameSI.Text == "s" && PassSI.Text == "1")
                {
                    Page1 p1 = new Page1();
                    p1.Show();
                }
            }
            if (checkBox1.Checked)
            {
                MessageBox.Show("We are saving your data");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpFor s = new SignUpFor();
            s.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
        }

        private void viewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are AIUBian for you. We maintain our cafe by AIUBian students.\nLove to take your order if you want we can deliver to you.\nDelivery is only availabe in side university area. Not outside of this universty area");
        }

        private void cafeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("01750096696 is our phone number.\nYou can find us beside of tong");
        }
    }
}

