using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InvitationDescription:BaseEntity
    {
        private AdvertistisingInvitations codeInvitation;
        private DateTime dateOfStart;
        private AdvertisingLocation codeLocation;
        private DateTime dateOfEnd;
        private string picture;

        public AdvertistisingInvitations CodeInvitation { get => codeInvitation; set => codeInvitation = value; }
        public DateTime DateOfStart { get => dateOfStart; set => dateOfStart = value; }
        public DateTime DateOfEnd { get => dateOfEnd; set => dateOfEnd = value; }
        public AdvertisingLocation CodeLocation { get => codeLocation; set => codeLocation = value; }
        public string Picture { get => picture; set => picture = value; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeInvitation" };
        }
        public override string GetTableName()
        {
            return "InvitationDescription";
        }
        public override string ToString()
        {
            return codeInvitation.ToString();
        }
    }
}
