using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AdvertisingLocation:BaseEntity
    {
        private int codeLocation;
        private string nameLocation;
        private int priceForDay;
        private string size;

        public int CodeLocation { get => codeLocation; set => codeLocation = value; }
        public string NameLocation { get => nameLocation; set => nameLocation = value; }
        public int PriceForDay { get => priceForDay; set => priceForDay = value; }
        public string Size { get => size; set => size = value; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeLocation" };
        }
        public override string GetTableName()
        {
            return "AdvertisingLocation";
        }
        public override string ToString()
        {
            return codeLocation.ToString();
        }
    }
}
