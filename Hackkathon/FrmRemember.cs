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
using LinQ;
using BUS_HACK;
namespace Hackkathon
{
    public partial class FrmRemember : DevExpress.XtraEditors.XtraForm
    {
        FrmDangNhap login= new FrmDangNhap();
        TruyXuatDataDataContext data = new TruyXuatDataDataContext();
        Bus func = new Bus();
        public FrmRemember()
        {
            InitializeComponent();
            getDanhSachChuaHoc();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var key=MessageBox.Show("Bạn Muốn Đăng Xuất", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                this.Hide();
                login.Show();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstChuaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //
        ///

        private void getDanhSachChuaHoc()
        {
            IQueryable<tbl_Dictionary> dic = func.getDsChuaHoc();
            foreach (var word in dic)
            {
                ListViewItem item = new ListViewItem(word.WORD);
                item.SubItems.Add(word.TYPE);
                lstChuaHoc.Items.Add(item);
            }

            
        }

        private void btnStartTraining_Click(object sender, EventArgs e)
        {
            //ListViewItem itemer = new ListViewItem();
            foreach(ListViewItem item in lstChuaHoc.Items)
            {
                if (item.Checked)
                {
                    lstTrainer.Items.Add(item.Text);
                    item.Checked = false;
                    //MessageBox.Show(item.Text);
                }
            }
        }
    }
}