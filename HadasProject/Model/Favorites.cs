using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Favorites:BaseEntity
    {
        private int codeFavorite;
        private string codeCustomer;
        private int codeItemForSale;

        public int CodeFavorite { get => codeFavorite; set => codeFavorite = value; }
        public string CodeCustomer { get => codeCustomer; set => codeCustomer = value; }
        public int CodeItemForSale { get => codeItemForSale; set => codeItemForSale = value; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeFavorite", "CodeCustomer", "CodeItemForSale" };
        }
        public override string GetTableName()
        {
            return "Favorites";
        }
        public override string ToString()
        {
            return codeFavorite.ToString()+codeCustomer.ToString()+codeItemForSale.ToString();
        }
    }
}
