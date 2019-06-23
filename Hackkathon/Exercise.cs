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
    public partial class Exercise : DevExpress.XtraEditors.XtraForm
    {
        public Exercise()
        {
            InitializeComponent();
        }

        Bus func = new Bus();
        private void lblDe_Click(object sender, EventArgs e)
        {

        }
    }
}