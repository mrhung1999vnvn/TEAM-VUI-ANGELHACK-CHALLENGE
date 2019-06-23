using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_HACK;
namespace Hackkathon
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        Bus truyXuat;
        FrmLearn main;
        FrmDangKy dk;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            truyXuat = new Bus();
            main = new FrmLearn();
        }
        private void InitializeMyControl()
        {
            // Set to no text.  
            txtPass.Text = "";
            // The password character is an asterisk.  
            txtPass.isPassword = true;
            // The control will allow no more than 14 characters.  
            
        }
        
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != "" && txtUser.Text != "")
            {
                if (truyXuat.kiemTraUser(txtUser.Text, txtPass.Text))
                {
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Xin điền đầy đủ thông tin phía trên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var key = MessageBox.Show("Bạn Muốn Thoát Chương Trình", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (key == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dk = new FrmDangKy();
            dk.Show();
        }
    }
}
