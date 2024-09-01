using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class AdvertisingLocationDB:BaseDB
    {
        public AdvertisingLocationDB() : base("AdvertisingLocation") { }
        public override BaseEntity CreateModel()
        {
            AdvertisingLocation item = new AdvertisingLocation();
            item.CodeLocation = Convert.ToInt32(reader["CodeLocation"]);
            item.NameLocation = (reader["NameLocation"]).ToString();
            item.PriceForDay = Convert.ToInt32(reader["PriceForDay"]);
            item.Size = reader["Size"].ToString();
            return item;
        }
        public List<AdvertisingLocation> GetList()
        {
            return base.list.Cast<AdvertisingLocation>().ToList();
        }
        public new List<AdvertisingLocation> GetCustBySelect(string nameField, string st)
        {
            return base.GetListBySelect(nameField, st).Cast<AdvertisingLocation>().ToList();
        }
        public List<AdvertisingLocation> GetListBySelectContain(string nameField, string st)
        {
            return base.GetListBySelectContain(nameField, st).Cast<AdvertisingLocation  >().ToList();
        }
        public AdvertisingLocation GetLocationByCode(int codeLocation)
        {
            return GetList().FirstOrDefault(x => x.CodeLocation == codeLocation);
        }
    }
}
