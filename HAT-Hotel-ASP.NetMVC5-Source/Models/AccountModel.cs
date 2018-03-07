using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using System.Data.SqlClient;

namespace Models
{
    public class AccountModel
    {
        private PiccatinhDbcontext context = null;

        public AccountModel()
        {
            context = new PiccatinhDbcontext();
        }
        public bool Login(string username, string password)
        {
            object[] Sqlparas =
            {
                new SqlParameter("@username",username),
                new SqlParameter("@password",password)

            };
            var res =
                context.Database.SqlQuery<bool>("Account_Login @username, @password", Sqlparas).SingleOrDefault();
            return res;

        }


    }
}
