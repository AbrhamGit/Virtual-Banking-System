using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VBS
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void custome_button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sign = new SignUp();
            sign.Show();
        }

        private void custome_button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void custome_button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        private void custome_button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
