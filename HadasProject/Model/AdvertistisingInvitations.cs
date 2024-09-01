using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AdvertistisingInvitations:BaseEntity
    {
        private int codeInvitation;
        private Sellers idSeller;
        private DateTime dateInvitation;
        private double amountForInvitation;
        private bool statusInvitation;

        public int CodeInvitation { get => codeInvitation; set => codeInvitation = value; }
        public Sellers IdSeller { get => idSeller; set => idSeller = value; }
        public DateTime DateInvitation { get => dateInvitation; set => dateInvitation = value; }
        public double AmountForInvitation { get => amountForInvitation; set => amountForInvitation = value; }
        public bool StatusInvitation { get => statusInvitation; set => statusInvitation = value; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeInvitation" };
        }
        public override string GetTableName()
        {
            return "AdvertisingInvitations";
        }
        public override string ToString()
        {
            return codeInvitation.ToString();
        }
    }
}
