using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customers:BaseEntity
    {
        private string codeCustomer;
        private string phoneCustomer;
        private string gmailCustomer;
        private bool statusCustomer;

        public string CodeCustomer { get => codeCustomer; set => codeCustomer = value; }
        public string PhoneCustomer { get => phoneCustomer; set => phoneCustomer = value; }
        public string GmailCustomer { get => gmailCustomer; set => gmailCustomer = value; }
        public bool StatusCustomer { get => statusCustomer; set => statusCustomer = value; }
        public override string[] GetKeyFields()
        {
            return new string[] { "CodeCustomer" };
        }
        public override string GetTableName()
        {
            return "Customers";
        }
        public override string ToString()
        {
            return CodeCustomer.ToString();
        }
    }
}
