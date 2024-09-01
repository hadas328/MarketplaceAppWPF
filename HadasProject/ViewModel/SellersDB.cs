using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class SellersDB:BaseDB
    {
        public SellersDB() : base("sellers") { }

        public override BaseEntity CreateModel()
        {
            Sellers item = new Sellers();
            item.IdSeller = reader["IdSeller"].ToString();
            item.CodeCity = Convert.ToInt32(reader["CodeCity"]);
            item.NameSeller = reader["NameSeller"].ToString();
            item.PhoneSeller = reader["PhoneSeller"].ToString() ;

            item.StatusSeller = Convert.ToBoolean(reader["StatusSeller"]);
            return item;
        }

        public List<Sellers> GetList()
        {
            return base.list.Cast<Sellers>().ToList();
        }

        public new List<Sellers> GetListBySelect(string nameField, string st)
        {
            return base.GetListBySelect(nameField, st).Cast<Sellers>().ToList();
        }

        public List<Sellers> GetListBySelectContain(string nameField, string st)
        {
            return base.GetListBySelectContain(nameField, st).Cast<Sellers>().ToList();
        }

        public Sellers GetSellersById(string idSeller)
        {
            return GetList().FirstOrDefault(x => x.IdSeller == idSeller);
        }
    }
}
