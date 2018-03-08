using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.DAO
{
    public class AccountDAO

    {
        ThelightHotelDbContext db = null;
        public AccountDAO()
        {
            db = new ThelightHotelDbContext();
        }
        public long Insert(Account entity)
        {
            db.Accounts.Add(entity);
            db.SaveChanges();
            return entity.ID;


        }
        public bool Login(string username, string password)
        {
            var result = db.Accounts.Count(x => x.UserName == username && x.Password == password);
            if (result > 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
