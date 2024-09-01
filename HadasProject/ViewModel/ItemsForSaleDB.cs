using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ItemsForSaleDB:BaseDB
    {
            public ItemsForSaleDB() : base("ItemsForSale") { }

            public override BaseEntity CreateModel()
            {
                ItemsForSale item = new ItemsForSale();
                item.CodeItemForSale = (Convert.ToInt32(reader["CodeItemForSale"]));
                item.IdSeller =MyDB.tblSellers.GetSellersById (reader["IdSeller"].ToString());
                item.PriceItemForSale = Convert.ToInt32(reader["PriceItemForSale"]);
                item.CodeLevel = MyDB.tbllevel.GetLevelByCode(Convert.ToInt32(reader["CodeLevel"]));
                item.AmountItemForSale = Convert.ToInt32(reader["AmountItemForSale"]);
            item.StatusItemForSale = Convert.ToBoolean(reader["StatusItemForSale"]);
                item.Picture = reader["Picture"].ToString();
            item.NameItem = (reader["NameItem"]).ToString();
            item.CodeSmallCategory = MyDB.tblSmallCategory.GetSmallCategoryByCode(Convert.ToInt32(reader["CodeSmallCategory"]));
            item.Description = reader["Description"].ToString();

            return item;
            }

            public List<ItemsForSale> GetList()
            {
                return base.list.Cast<ItemsForSale>().ToList();
            }

            public new List<ItemsForSale> GetListBySelect(string nameField, string st)
            {
                return base.GetListBySelect(nameField, st).Cast<ItemsForSale>().ToList();
            }

            public List<ItemsForSale> GetListBySelectContain(string nameField, string st)
            {
                return base.GetListBySelectContain(nameField, st).Cast<ItemsForSale>().ToList();
            }

            public ItemsForSale GetItemsForSaleByCode(int codeItemForSale)
            {
                return GetList().FirstOrDefault(x => x.CodeItemForSale == codeItemForSale);
            }
        }
}
