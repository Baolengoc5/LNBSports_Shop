using Models.Frameworks;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private LNBSports_ShopDbcontext context = null;
        public AccountModel()
        {
            context = new LNBSports_ShopDbcontext();
        }
        public bool Login(string username, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@UserName",username),
                new SqlParameter("@Password", password)
        };
            var res = context.Database.SqlQuery<bool>("Sp_User_Login @UserName,@Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
