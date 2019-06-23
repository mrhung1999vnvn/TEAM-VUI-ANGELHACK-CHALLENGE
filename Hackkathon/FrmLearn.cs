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

namespace Hackkathon
{
    public partial class FrmLearn : DevExpress.XtraEditors.XtraForm
    {
        FrmDangNhap login;
        FrmRemember remember;
        public FrmLearn()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmLearn_Load(object sender, EventArgs e)
        {
            login = new FrmDangNhap();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            remember = new FrmRemember();
            remember.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var key = MessageBox.Show("Bạn Muốn Đăng Xuất", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                login.Show();
                this.Hide();
            }
        }
    }
}