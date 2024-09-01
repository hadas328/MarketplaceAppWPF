using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sellers:BaseEntity
    {
        private string idSeller;
        private string nameSeller;
        private string phoneSeller;
        private int codeCity;
        private bool statusSeller;

        public string IdSeller { get => idSeller; set => idSeller = value; }
        public int CodeCity { get => codeCity; set => codeCity = value; }

        public bool StatusSeller { get => statusSeller; set => statusSeller = value; }
        public string NameSeller { get => nameSeller; set => nameSeller = value; }
        public string PhoneSeller { get => phoneSeller; set => phoneSeller = value; }

        public override string[] GetKeyFields()
        {
            return new string[] { "IdSeller" };
        }
        public override string GetTableName()
        {
            return "sellers";
        }
        public override string ToString()
        {
            return IdSeller.ToString();
        }
    }
}
