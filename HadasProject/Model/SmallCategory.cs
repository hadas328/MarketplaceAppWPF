using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SmallCategory:BaseEntity
    {
        private int codeSmallCategory;
        private string nameSmallCategory;
        private Category codeCategory;

        public int CodeSmallCategory { get => codeSmallCategory; set => codeSmallCategory = value; }
        public string NameSmallCategory { get => nameSmallCategory; set => nameSmallCategory = value; }
        public Category CodeCategory { get => codeCategory; set => codeCategory = value; }
        public override string[] GetKeyFields()
        {
            return new string[] { "CodeSmallCategory" };
        }
        public override string GetTableName()
        {
            return "SmallCategory";
        }
        public override string ToString()
        {
            return CodeSmallCategory.ToString();
        }
    }
}
