using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Category:BaseEntity
    {
        private int codeCategory;
        private string nameCategory;
        private string pictureCategory;

        public int CodeCategory { get => codeCategory; set => codeCategory = value; }
        public string NameCategory { get => nameCategory; set => nameCategory = value; }
        public string PictureCategory { get => pictureCategory ; set => pictureCategory = value; }



        public override string[] GetKeyFields()
        {
            return new string[] { "CodeCategory" };
        }
        public override string GetTableName()
        {
            return "Category";
        }
        public override string ToString()
        {
            return codeCategory.ToString();
        }
    }
}
