using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            //גם כאן הבנייה חיבת להיות לפי סדר אחרת זה לא יעבוד
           AdvertisingLocation advertisingLocationObject=new AdvertisingLocation() {CodeLocation=1,NameLocation=" left", PriceForDay=300};
            Sellers sellersObject = new Sellers() { IdSeller = "515151", CodeCity = 3, StarsSellers = 5, StatusSeller = true };
            AdvertistisingInvitations advertistisingInvitationsObject = new AdvertistisingInvitations() {IdSeller=sellersObject, CodeInvitation=898542, DateInvitation=DateTime.Today, AmountForInvitation=450};
           Category categoryObject = new Category() {CodeCategory=1235, NameCategory="ספורט"};
           Customers customersObject = new Customers() {CodeCustomer=12566 ,PhoneCustomer="0527612314", GmailCustomer="zipi2648@gmail.com", StatusCustomer=true };
           Dirog dirogObject = new Dirog() { CodeCustomers= customersObject ,IdSeller=sellersObject ,Stars=5};
            LevelI levelObject = new LevelI() {CodeLevel=2,NameLevel="משומש" };

            MyDB.tblAdvertisingLocation.Insert(advertisingLocationObject);
            MyDB.tblSellers.Insert(sellersObject);  
            MyDB.tblAdvertisingInvitations.Insert(advertistisingInvitationsObject);
            MyDB.tblCustomers.Insert(customersObject);
            MyDB.tblCategory.Insert(categoryObject);
            MyDB.tblCustomers.Insert(customersObject);
            MyDB.tblDirog.Insert(dirogObject);
     
            MyDB.tbllevel.Insert(levelObject);


            Print(MyDB.tblCategory.GetList().Cast<BaseEntity>().ToList());
            Print(MyDB.tblAdvertisingLocation.GetList().Cast<BaseEntity>().ToList());
            Print(MyDB.tblSellers.GetList().Cast<BaseEntity>().ToList());
            Print(MyDB.tblAdvertisingInvitations.GetList().Cast<BaseEntity>().ToList());
            Print(MyDB.tblinvitationDescription.GetList().Cast<BaseEntity>().ToList());
            Print(MyDB.tblDirog.GetList().Cast<BaseEntity>().ToList());
            Print(MyDB.tblCustomers.GetList().Cast<BaseEntity>().ToList());
            Print(MyDB.tbllevel.GetList().Cast<BaseEntity>().ToList());
            //Print(MyDB.tblItemsdescription.GetList().Cast<BaseEntity>().ToList());
            Print(MyDB.tblinvitationDescription.GetList().Cast<BaseEntity>().ToList());
            Print(MyDB.tblItemsForSale.GetList().Cast<BaseEntity>().ToList());
            Print(MyDB.tblPayment.GetList().Cast<BaseEntity>().ToList());

        }
        public static void Print(List<BaseEntity> lst)
        {
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================");
            Console.ReadLine();
        }
    }
}
