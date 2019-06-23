using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LinQ;
namespace DAL_HACK
{
    public class DAL:Connect
    {
        
        public bool KiemTraUser(string name,string pass)
        {
            
            try
            {
                TruyXuatDataDataContext data = new TruyXuatDataDataContext(cnt);
                var linq = from person in data.tbl_Users
                           where name == person.USERNAME.Trim() && pass == person.PASSWORD
                           select person;
                if (linq != null)
                {
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }
        
        ///For Learn
       public IQueryable<tbl_Dictionary> getSource()
       {
            try
            {
                TruyXuatDataDataContext data = new TruyXuatDataDataContext();
                var linq = from th in data.tbl_Dictionaries
                           select th;
                return linq;
                
            }
            catch
            {

            }
            return null;
       }
       public IQueryable<tbl_Baitap> baiTap(string id)
        {
            try
            {
                TruyXuatDataDataContext data = new TruyXuatDataDataContext();
                var linq = from th in data.tbl_Baitaps
                           where id==th.ID
                           select th;
                return linq;
            }
            catch
            {

            }
            return null;
        }
        public bool DangKyTaiKhoan(string username,string password)
        {
            TruyXuatDataDataContext context = new TruyXuatDataDataContext(cnt);
            tbl_User course = new tbl_User
            {
                ID ="002",
                USERNAME = username,
                PASSWORD = password,
            };
            context.tbl_Users.InsertOnSubmit(course);

            try
            {
                context.SubmitChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }
    }
}
