using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class AdvertisingInvitationsDB:BaseDB
    {
        public AdvertisingInvitationsDB() : base("AdvertisingInvitations") { }
        public override BaseEntity CreateModel()
        {
            AdvertistisingInvitations item = new AdvertistisingInvitations();
            item.CodeInvitation = (Convert.ToInt32(reader["CodeInvitation"]));
            item.IdSeller = MyDB.tblSellers.GetSellersById(reader["IdSeller"].ToString());
            item.DateInvitation = Convert.ToDateTime(reader["DateInvitation"]);
            item.AmountForInvitation = Convert.ToInt32(reader["AmountForInvitation"]);
            item.StatusInvitation = Convert.ToBoolean(reader["StatusInvitation"]);
            return item;
        }
        public List<AdvertistisingInvitations> GetList()
        {
            return base.list.Cast<AdvertistisingInvitations>().ToList();
        }
        public new List<AdvertistisingInvitations> GetCustBySelect(string nameField, string st)
        {
            return base.GetListBySelect(nameField, st).Cast<AdvertistisingInvitations>().ToList();
        }
        public List<AdvertistisingInvitations> GetListBySelectContain(string nameField, string st)
        {
            return base.GetListBySelectContain(nameField, st).Cast<AdvertistisingInvitations>().ToList();
        }
        public AdvertistisingInvitations GetAdvertisingInvitationsByCode(int codeInvitatation)
        {
            return GetList().FirstOrDefault(x => x.CodeInvitation == codeInvitatation);
        }




    }
}
