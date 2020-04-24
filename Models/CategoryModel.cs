using Models.Frameworks;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public int Create(string Name, string MetaTitle, long? ParentID, int? DisplayOrder, string SeoTitle, string CreatedBy,
            string MetaKeywords, string MetaDescriptions, bool? Status, bool? ShowOnHome, string Language)
        {
            object[] parameters =
            {
                new SqlParameter("@Name",Name),
                new SqlParameter("@MetaTitle",MetaTitle),
                new SqlParameter("@ParentID",ParentID),
                new SqlParameter("@DisplayOrder",DisplayOrder),
                new SqlParameter("@SeoTitle",SeoTitle),
                new SqlParameter("@CreatedBy",CreatedBy),
                new SqlParameter("@MetaKeywords",MetaKeywords),
                new SqlParameter("@MetaDescriptions",MetaDescriptions),
                new SqlParameter("@Status",Status),
                new SqlParameter("@ShowOnHome",ShowOnHome),
                new SqlParameter("@Language",Language),
            };
            int res = context.Database.ExecuteSqlCommand("Sp_Category_Insert @Name,@MetaTitle,@ParentID,@DisplayOrder,@SeoTitle,@CreatedBy,@MetaKeywords, @MetaDescriptions, @Status, @ShowOnHome, @Language",parameters);
            return res;
        }
    }
}
