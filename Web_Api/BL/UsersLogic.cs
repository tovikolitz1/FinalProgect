using BL.Extentions;
using BL.ModelDTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class UsersLogic
    {
        static RavKav db = new RavKav();

        public static bool AddUser(UserDTO user)
        {
            UserTbl u = Extend.CreateUserTbl(user);
            try
            {
                using (RavKav r = new RavKav())
                {
                    r.UserTbls.Add(u);
                    r.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static int CalculateThePayment(string id)
        {
            return 1;
        }
        public static int IfExsistRavKav(string ravKav, string pass)
        {
            if (db.UserTbls.Any(a => a.ravkav.Equals(ravKav) && a.password.Equals(pass)))
                return db.UserTbls.Where(a => a.ravkav.Equals(ravKav) && a.password.Equals(pass)).Select(a => a.id).FirstOrDefault();
            return 0;
        }
        public static string GetNameById(int id)
        {
             return db.UserTbls.Where(x=> x.id==id).Select(x=> x.firstName+" "+x.lastName).ToString();
        }
    }
}