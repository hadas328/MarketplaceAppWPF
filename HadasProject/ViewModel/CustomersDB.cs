using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CustomersDB:BaseDB
    {
            public CustomersDB() : base("Customers") { }
            public override BaseEntity CreateModel()
            {
                Customers item = new Customers();
                item.CodeCustomer = (reader["CodeCustomer"]).ToString();
                item.PhoneCustomer = (reader["PhoneCustomer"]).ToString();
                item.GmailCustomer = reader["GmailCustomer"].ToString();
            
                return item;
            }
            public List<Customers> GetList()
            {
                return base.list.Cast<Customers>().ToList();
            }
            public new List<Customers> GetCustBySelect(string nameField, string st)
            {
                return base.GetListBySelect(nameField, st).Cast<Customers>().ToList();
            }
            public List<Customers> GetListBySelectContain(string nameField, string st)
            {
                return base.GetListBySelectContain(nameField, st).Cast<Customers>().ToList();
            }
            public Customers GetCustomersByCode(string codeCustomer)
            {
                return GetList().FirstOrDefault(x => x.CodeCustomer == codeCustomer);
            }
        }
}
