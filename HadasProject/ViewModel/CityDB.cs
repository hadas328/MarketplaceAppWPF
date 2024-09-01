using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CityDB:BaseDB
    {
        public CityDB() : base("City") { }
        public override BaseEntity CreateModel()
        {
            City item = new City();
            item.CodeCity = Convert.ToInt32(reader["CodeCity"]);
            item.NameCity = reader["NameCity"].ToString();
            return item;
        }
        public List<City> GetList()
        {
            return base.list.Cast<City>().ToList();
        }
        public new List<City> GetCityBySelect(string nameField, string st)
        {
            return base.GetListBySelect(nameField, st).Cast<City>().ToList();
        }
        public List<City> GetListBySelectContain(string nameField, string st)
        {
            return base.GetListBySelectContain(nameField, st).Cast<City>().ToList();
        }
        public City GetCityByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.CodeCity == code);
        }
    }
}
