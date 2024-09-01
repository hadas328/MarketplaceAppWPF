using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class FavoritesDB : BaseDB
    {
        public FavoritesDB() : base("Favorites") { }

        public override BaseEntity CreateModel()
        {
            Favorites item = new Favorites();
            item.CodeFavorite= Convert.ToInt32(reader["CodeFavorite"]);
            item.CodeCustomer = (reader["CodeCustomer"]).ToString();
            item.CodeItemForSale = Convert.ToInt32(reader["CodeItemForSale"]);
            return item;
        }
        public List<Favorites> GetList()
        {
            return base.list.Cast<Favorites>().ToList();
        }
        public new List<Favorites> GetCustBySelect(string nameField, string st)
        {
            return base.GetListBySelect(nameField, st).Cast<Favorites>().ToList();
        }
        public List<Favorites> GetListBySelectContain(string nameField, string st)
        {
            return base.GetListBySelectContain(nameField, st).Cast<Favorites>().ToList();
        }
        public Favorites GetFavoriteByCode(int codeFavorite,string  codeCustomer,int codeItemForSale)
        {
            return GetList().FirstOrDefault(x => x.CodeFavorite == codeFavorite&&x.CodeCustomer==codeCustomer&& x.CodeItemForSale==codeItemForSale );
        }
    }
}
