using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PaymentDB:BaseDB
    {

            public PaymentDB() : base("Payment") { }

            public override BaseEntity CreateModel()
            {
                Payment item = new Payment();
                item.CodePayment = Convert.ToInt32(reader["CodePayment"]);
                item.NameOfCardHolder = reader["NameOfCardHolder"].ToString();
                item.NumberCard = (reader["NumberCard"]).ToString();
                item.Validity = reader["Validity"].ToString();
                item.ThreeDigitsInTheBackOfTheCard = reader["ThreeDigitsInTheBackOfTheCard"].ToString();
                item.IdOfTheCardOwner = reader["IdOfTheCardOwner"].ToString();
                item.CodeInvitation = MyDB.tblAdvertisingInvitations.GetAdvertisingInvitationsByCode(Convert.ToInt32(reader["CodeInvitation"]));
                item.Amount = Convert.ToInt32(reader["Amount"]);
                item.NumberOfThePayment = reader["NumberOfThePayment"].ToString();
                item.StausPayment = Convert.ToBoolean(reader["StausPayment"]);
                return item;
            }

            public List<Payment> GetList()
            {
                return base.list.Cast<Payment>().ToList();
            }

            public new List<Payment> GetListBySelect(string nameField, string st)
            {
                return base.GetListBySelect(nameField, st).Cast<Payment>().ToList();
            }

            public List<Payment> GetListBySelectContain(string nameField, string st)
            {
                return base.GetListBySelectContain(nameField, st).Cast<Payment>().ToList();
            }

            public Payment GetPaymentByCode(int codePayment)
            {
                return GetList().FirstOrDefault(x => x.CodePayment == codePayment);
            }
        }
    }
