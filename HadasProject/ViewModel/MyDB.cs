using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public static class MyDB
    {
        //לא לשכוח את הערה שהמורה אמרה לגבי מחלקה זו :
        //שהעצמים מסוג הטבלאות שאינן מכילות נכתבים ראשונים והעצמים שמכילים נכתבים שניים
        public static CategoryDB tblCategory = new CategoryDB();
        public static LevelDB tbllevel = new LevelDB();
        public static CityDB tblcity=new CityDB();
        public static SellersDB tblSellers = new SellersDB();
        public static CustomersDB tblCustomers = new CustomersDB();
        public static AdvertisingLocationDB tblAdvertisingLocation = new AdvertisingLocationDB();

        public static AdvertisingInvitationsDB tblAdvertisingInvitations = new AdvertisingInvitationsDB();
        public static InvitationDescriptionDB tblinvitationDescription = new InvitationDescriptionDB();

        public static PaymentDB tblPayment= new PaymentDB();

        public static SmallCategoryDB tblSmallCategory = new SmallCategoryDB();


        public static ItemsForSaleDB tblItemsForSale = new ItemsForSaleDB();
        public static FavoritesDB tblFavorites = new FavoritesDB();


    }

}
