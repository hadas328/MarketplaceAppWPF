using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class InvitationDescriptionDB:BaseDB
    {
        public InvitationDescriptionDB() : base("invitationDescription") { }
        public override BaseEntity CreateModel()
        {
            InvitationDescription item = new InvitationDescription();
            item.CodeInvitation = MyDB.tblAdvertisingInvitations.GetAdvertisingInvitationsByCode(Convert.ToInt32(reader["CodeInvitation"]));
            item.DateOfStart = Convert.ToDateTime(reader["DateOfStart"]);
            item.DateOfEnd = Convert.ToDateTime(reader["DateOfEnd"]);
            item.CodeLocation = MyDB.tblAdvertisingLocation.GetLocationByCode(Convert.ToInt32(reader["CodeLocation"]));
            item.Picture = (reader["Picture"]).ToString();

            return item;
        }
        public List<InvitationDescription> GetList()
        {
            return base.list.Cast<InvitationDescription>().ToList();
        }
        public new List<InvitationDescription> GetCustBySelect(string nameField, string st)
        {
            return base.GetListBySelect(nameField, st).Cast<InvitationDescription>().ToList();
        }
        public List<InvitationDescription> GetListBySelectContain(string nameField, string st)
        {
            return base.GetListBySelectContain(nameField, st).Cast<InvitationDescription>().ToList();
        }
        public InvitationDescription GetInvitationDescriptionByCode(int codeInvitation)
        {
            return GetList().FirstOrDefault(x => x.CodeInvitation.CodeInvitation == codeInvitation);
        }
    }
}
