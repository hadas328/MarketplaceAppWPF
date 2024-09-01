using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class SmallCategoryDB:BaseDB
    {
        public SmallCategoryDB() : base("SmallCategory") { }
        public override BaseEntity CreateModel()
        {
            SmallCategory item = new SmallCategory();
            item.CodeSmallCategory= Convert.ToInt32(reader["CodeSmallCategory"]);
            item.NameSmallCategory = (reader["NameSmallCategory"]).ToString();
            item.CodeCategory = MyDB.tblCategory.GetCategoryByCode(Convert.ToInt32(reader["CodeCategory"]));
            return item;
        }
        public List<SmallCategory> GetList()
        {
            return base.list.Cast<SmallCategory>().ToList();
        }
        public new List<SmallCategory> GetCustBySelect(string nameField, string st)
        {
            return base.GetListBySelect(nameField, st).Cast<SmallCategory>().ToList();
        }
        public List<SmallCategory> GetListBySelectContain(string nameField, string st)
        {
            return base.GetListBySelectContain(nameField, st).Cast<SmallCategory>().ToList();
        }
        public SmallCategory GetSmallCategoryByCode(int codeSmallCategory)
        {
            return GetList().FirstOrDefault(x => x.CodeSmallCategory == codeSmallCategory);
        }
    }
}
