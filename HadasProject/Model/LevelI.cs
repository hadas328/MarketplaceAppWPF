using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LevelI:BaseEntity
    {
        private int codeLevel;
        private string nameLevel;

        public int CodeLevel { get => codeLevel; set => codeLevel = value; }
        public string NameLevel { get => nameLevel; set => nameLevel = value; }
        public override string[] GetKeyFields()
        {
            return new string[] { "CodeLevel" };
        }
        public override string GetTableName()
        {
            return "LevelI";
        }
        public override string ToString()
        {
            return codeLevel.ToString();
        }
    }
}
