using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Sing_up : Form
    {
        public Sing_up()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.text=="User name")
            {
                txtUser.text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.text == "")
            {
                txtUser.text = "User name";
            }
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.text == "Email")
            {
                txtMail.text = "";
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.text == "")
            {
                txtMail.text = "Email";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.text == "Password")
            {
                txtPass.text = "";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.text == "")
            {
                txtPass.text = "Password";
            }
        }

        private void txtConfigPass_Enter(object sender, EventArgs e)
        {
            if (txtConfigPass.text == "Password")
            {
                txtConfigPass.text = "";
            }
        }

        private void txtConfigPass_Leave(object sender, EventArgs e)
        {
            if (txtConfigPass.text == "")
            {
                txtConfigPass.text = "Password";
            }
        }

       

        private void lbAcc_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void txtUser_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void txtMail_OnTextChange(object sender, EventArgs e)
        {
            if (txtUser.text == "")
            {
                txtUser.Focus();
            }
            
        }

        private void txtPass_OnTextChange(object sender, EventArgs e)
        {
            if (txtMail.text == "")
            {
                txtMail.Focus();
            }
           
        }

        private void txtConfigPass_OnTextChange(object sender, EventArgs e)
        {
            if (txtPass.text == "")
            {
                txtPass.Focus();
            }
            
        }

        private void btSignup_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
