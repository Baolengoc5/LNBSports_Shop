using Models.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CategoryModel
    {
        private LNBSports_ShopDbcontext context = null;
        public CategoryModel()
        {
            context = new LNBSports_ShopDbcontext();
        }
        public List<Category> ListAll()
        {
            var list = context.Database.SqlQuery<Category>("Sp_Category_ListAll").ToList();
            return list;
        }
    }
}
