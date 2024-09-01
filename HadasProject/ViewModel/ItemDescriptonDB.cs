using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ItemDescriptionDB:BaseDB
    {
        public ItemDescriptionDB() : base("ItemDescription") { }
        public override BaseEntity CreateModel()
        {
            ItemDescription item = new ItemDescription();
            item.CodeItem = Convert.ToInt32(reader["CodeItem"]);
            item.NameItem =(reader["NameItem"]).ToString();
            item.CodeSmallCategory = MyDB.tblSmallCategory.GetSmallCategoryByCode(Convert.ToInt32(reader["CodeSmallCategory"]));
            return item;
        }
        public List<ItemDescription> GetList()
        {
            return base.list.Cast<ItemDescription>().ToList();
        }
        public new List<ItemDescription> GetCustBySelect(string nameField, string st)
        {
            return base.GetListBySelect(nameField, st).Cast<ItemDescription>().ToList();
        }
        public List<InvitationDescription> GetListBySelectContain(string nameField, string st)
        {
            return base.GetListBySelectContain(nameField, st).Cast<InvitationDescription>().ToList();
        }
        public ItemDescription GetItemDescriptionByCode(int codeItem)
        {
            return GetList().FirstOrDefault(x => x.CodeItem == codeItem);
        }
    }
}
