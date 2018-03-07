using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using Models;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Models
{
    public class CategoryModel
    {
        private PiccatinhDbcontext context = null;
        public CategoryModel()
        {
            context = new PiccatinhDbcontext();
        }
        public List<Category> ListAll()
        {
            var list = context.Database.SqlQuery<Category>("Sp_Category_ListAll").ToList();
            return list;
        }
        public int Create(int id, string name, string alias, int? parentID, int? order, bool? status)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@ID",id),
                new SqlParameter("@Name",name),
                new SqlParameter("@Alias",alias),
                new SqlParameter("@ParentID", parentID),
                new SqlParameter("@Order", order),
                new SqlParameter("@Status", status)
        };
        int res = context.Database.ExecuteSqlCommand("Category_Insert @ID,@Name, @Alias, @ParentID,@Order,@Status",parameters);
            return res;
        }
}
}
