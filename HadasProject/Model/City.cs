using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class City:BaseEntity
    {
        private int codeCity;
        private string nameCity;

        public string NameCity { get => nameCity; set => nameCity = value; }
        public int CodeCity { get => codeCity; set => codeCity = value; }
        public override string[] GetKeyFields()
        {
            return new string[] { "CodeCity" };
        }
        public override string GetTableName()
        {
            return "City";
        }
        public override string ToString()
        {
            return CodeCity.ToString();
        }
    }
}
