using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class ItemDescription:BaseEntity
    {
        private int codeItem;
        private string nameItem;
        private SmallCategory codeSmallCategory;

        public int CodeItem { get => codeItem; set => codeItem = value; }
        public string NameItem { get => nameItem; set => nameItem = value; }
        public SmallCategory CodeSmallCategory { get => codeSmallCategory; set => codeSmallCategory = value; }
        public override string[] GetKeyFields()
        {
            return new string[] { "CodeItem" };
        }
        public override string GetTableName()
        {
            return "ItemDescription";
        }
        public override string ToString()
        {
            return CodeItem.ToString();
        }
    }
}
