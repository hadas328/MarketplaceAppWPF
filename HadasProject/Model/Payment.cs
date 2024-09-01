using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Payment:BaseEntity
    {
        private int codePayment;
        private string nameOfCardHolder;
        private string numberCard;
        private string validity;
        private string threeDigitsInTheBackOfTheCard;
        private string idOfTheCardOwner;
        private AdvertistisingInvitations codeInvitation;
        private int amount;
        private string numberOfThePayment;
        private bool stausPayment;

        public int CodePayment { get => codePayment; set => codePayment = value; }
        public string NameOfCardHolder { get => nameOfCardHolder; set => nameOfCardHolder = value; }
        public string NumberCard { get => numberCard; set => numberCard = value; }
        public string Validity { get => validity; set => validity = value; }
        public string ThreeDigitsInTheBackOfTheCard { get => threeDigitsInTheBackOfTheCard; set => threeDigitsInTheBackOfTheCard = value; }
        public string IdOfTheCardOwner { get => idOfTheCardOwner; set => idOfTheCardOwner = value; }
        public AdvertistisingInvitations CodeInvitation { get => codeInvitation; set => codeInvitation = value; }
        public int Amount { get => amount; set => amount = value; }
        public string NumberOfThePayment { get => numberOfThePayment; set => numberOfThePayment = value; }
        public bool StausPayment { get => stausPayment; set => stausPayment = value; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodePayment" };
        }
        public override string GetTableName()
        {
            return "Payment";
        }
        public override string ToString()
        {
            return codePayment.ToString();
        }
    }
}
