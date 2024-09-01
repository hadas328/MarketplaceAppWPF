using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class LevelDB:BaseDB
    {
        public LevelDB() : base("LevelI") { }

        public override BaseEntity CreateModel()
        {
            LevelI item = new LevelI();
            item.CodeLevel = Convert.ToInt32(reader["CodeLevel"]);
            item.NameLevel = reader["NameLevel"].ToString();
            return item;
        }

        public List<LevelI> GetList()
        {
            return base.list.Cast<LevelI>().ToList();
        }

        public new List<LevelI> GetListBySelect(string nameField, string st)
        {
            return base.GetListBySelect(nameField, st).Cast<LevelI>().ToList();
        }

        public List<LevelI> GetListBySelectContain(string nameField, string st)
        {
            return base.GetListBySelectContain(nameField, st).Cast<LevelI>().ToList();
        }

        public LevelI GetLevelByCode(int codeLevel)
        {
            return GetList().FirstOrDefault(x => x.CodeLevel == codeLevel);
        }
    }
}
