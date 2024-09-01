using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ItemsForSale: BaseEntity
    {
        private int codeItemForSale;
        private Sellers idSeller;
        private int priceItemForSale;
        private LevelI codeLevel;
        private int amountItemForSale;
        private bool statusItemForSale;
        private string picture;
        private string nameItem;
        private SmallCategory codeSmallCategory;
        private string description;

        public int CodeItemForSale { get => codeItemForSale; set => codeItemForSale = value; }
        public Sellers IdSeller { get => idSeller; set => idSeller = value; }
        public int PriceItemForSale { get => priceItemForSale; set => priceItemForSale = value; }
        public LevelI CodeLevel { get => codeLevel; set => codeLevel = value; }
        public int AmountItemForSale { get => amountItemForSale; set => amountItemForSale = value; }
        public bool StatusItemForSale { get => statusItemForSale; set => statusItemForSale = value; }
        public string Picture { get => picture; set => picture = value; }
        public string NameItem { get => nameItem; set => nameItem = value; }
        public SmallCategory CodeSmallCategory { get => codeSmallCategory; set => codeSmallCategory = value; }
        public string Description { get => description; set => description = value; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeItemForSale" };
        }
        public override string GetTableName()
        {
            return "ItemsForSale";
        }
        public override string ToString()
        {
            return codeItemForSale.ToString();
        }
    }
}
