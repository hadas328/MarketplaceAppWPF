using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CategoryDB:BaseDB
    {
        public CategoryDB() : base("Category") { }
        public override BaseEntity CreateModel()
        {
            Category item = new Category();
            item.CodeCategory = Convert.ToInt32(reader["CodeCategory"]);
            item.NameCategory = (reader["NameCategory"]).ToString();
            item.PictureCategory = reader["PictureCategory"].ToString();
            return item;
        }
        public List<Category> GetList()
        {
            return base.list.Cast<Category>().ToList();
        }
        public new List<Category> GetCustBySelect(string nameField, string st)
        {
            return base.GetListBySelect(nameField, st).Cast<Category>().ToList();
        }
        public List<Category> GetListBySelectContain(string nameField, string st)
        {
            return base.GetListBySelectContain(nameField, st).Cast<Category>().ToList();
        }
        public Category GetCategoryByCode(int codeCategory)
        {
            return GetList().FirstOrDefault(x => x.CodeCategory == codeCategory);
        }
    }
}
