﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Frameworks;
using System.Data.SqlClient;

namespace Models
{
    public class AccountModels
    {
        private LNBSports_ShopDbcontext context = null;
        public AccountModels()
        {
            context = new LNBSports_ShopDbcontext();
        }
        public int Login(string username, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@UserName",username),
                new SqlParameter("@Password", password)
        };
            var res = context.Database.SqlQuery<int>("Sp_User_Login @UserName,@Password",sqlParams).SingleOrDefault();
            return res;
        }
    }
}
