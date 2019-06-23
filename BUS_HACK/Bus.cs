using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_HACK;
using LinQ;

namespace BUS_HACK
{
    public class Bus
    {
        DAL data = new DAL();
        public bool kiemTraUser(string name,string pass)
        {
            return data.KiemTraUser(name, pass);
        }
        public IQueryable<tbl_Dictionary> getDsChuaHoc()
        {
            return data.getSource();
        }
        public IQueryable<tbl_Baitap> getBaiTap(string id)
        {
            return data.baiTap(id);
        }
        public bool DKTaiKhoan(string username,string pass)
        {
            return data.DangKyTaiKhoan(username, pass);
        }
    }
}
