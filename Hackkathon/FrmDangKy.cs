using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS_HACK;
namespace Hackkathon
{
    public partial class FrmDangKy : DevExpress.XtraEditors.XtraForm
    {
        Bus func = new Bus();
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" || txtPass.Text != "")
            {
                if (func.kiemTraUser(txtUser.Text, txtPass.Text))
                {
                    MessageBox.Show("Success Login", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all above");
            }
        }
    }
}