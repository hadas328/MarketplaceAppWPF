using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel;
using WcfServiceLibrary1;
using System.Drawing;

namespace WcfServiceLibrary1
{
    public class ServiceHadas : IServiceHadas
    {
        #region Add Methods


        public void AddItemsForSale(ItemsForSale itemsForSale)
        {
            MyDB.tblItemsForSale.Insert(itemsForSale);
            MyDB.tblItemsForSale.SaveChanges();
        }
        public void AddCategory(Category category)
        {
            MyDB.tblCategory.Insert(category);
            MyDB.tblCategory.SaveChanges();
        }
        public void AddSmallCategory(SmallCategory smallCategory)
        {
            MyDB.tblSmallCategory.Insert(smallCategory);
            MyDB.tblSmallCategory.SaveChanges();
        }
        public void AddLevel(LevelI level)
        {
            MyDB.tbllevel.Insert(level);
            MyDB.tbllevel.SaveChanges();
        }
        public void AddCity(City city)
        {
            MyDB.tbllevel.Insert(city);
            MyDB.tbllevel.SaveChanges();
        }
        public void AddSellers(Sellers sellers)
        {
            MyDB.tblSellers.Insert(sellers);
            MyDB.tblSellers.SaveChanges();
        }
        public void AddCustomers(Customers customers)
        {
            MyDB.tblCustomers.Insert(customers);
            MyDB.tblCustomers.SaveChanges();
        }

        public void AddFavorite(Favorites favorites)
        {
            MyDB.tblFavorites.Insert(favorites);
            MyDB.tblFavorites.SaveChanges();
        }
        public void AddAdvertisingLocation(AdvertisingLocation advertisingLocation)
        {
            MyDB.tblAdvertisingLocation.Insert(advertisingLocation);
            MyDB.tblAdvertisingLocation.SaveChanges();
        }

        public void AddInvitationDescription(InvitationDescription invitationDescription)
        {
            MyDB.tblinvitationDescription.Insert(invitationDescription);
            MyDB.tblinvitationDescription.SaveChanges();
        }
        public void AddAdvertisingInvitations(AdvertistisingInvitations advertistisingInvitations)
        {
            MyDB.tblAdvertisingInvitations.Insert(advertistisingInvitations);
            MyDB.tblAdvertisingInvitations.SaveChanges();
        }
        public void AddPayment(Payment payment)
        {
            MyDB.tblPayment.Insert(payment);
            MyDB.tblPayment.SaveChanges();
        }
        #endregion
        #region Delete Methods

        public void DeleteSmallCategory(SmallCategory smallCategory)
        {
            MyDB.tblSmallCategory.Delete(smallCategory);
            MyDB.tblSmallCategory.SaveChanges();
        }
        public void DelItemForSale(ItemsForSale itemsForSale)
        {
            MyDB.tblItemsForSale.Delete(itemsForSale);
            MyDB.tblItemsForSale.SaveChanges();
        }
        public void DeleteCategory(Category category)
        {
            MyDB.tblCategory.Delete(category);
            MyDB.tblCategory.SaveChanges();
        }
        public void DelLevel(LevelI level)
        {
            MyDB.tbllevel.Delete(level);
            MyDB.tbllevel.SaveChanges();
        }
        public void DelCity(City city)
        {
            MyDB.tblcity.Delete(city);
            MyDB.tblcity.SaveChanges();
        }
        public void DeleteSellers(Sellers sellers)
        {
            MyDB.tblSellers.Delete(sellers);
            MyDB.tblSellers.SaveChanges();
        }
        public void DelCustomers(Customers customers)
        {
            MyDB.tblCustomers.Delete(customers);
            MyDB.tblCustomers.SaveChanges();
        }

        public void DeleteFavorites(Favorites favorites)
        {
            MyDB.tblFavorites.Delete(favorites);
            MyDB.tblFavorites.SaveChanges();
        }
        public void DelAdvertisingLocation(AdvertisingLocation advertisingLocation)
        {
            MyDB.tblAdvertisingLocation.Delete(advertisingLocation);
            MyDB.tblAdvertisingLocation.SaveChanges();
        }
        public void DeleteInvitationDescription(InvitationDescription invitationDescription)
        {
            MyDB.tblinvitationDescription.Delete(invitationDescription);
            MyDB.tblinvitationDescription.SaveChanges();
        }
        public void DelAdvertisingInvitations(AdvertistisingInvitations advertistisingInvitations)
        {
            MyDB.tblAdvertisingInvitations.Delete(advertistisingInvitations);
            MyDB.tblAdvertisingInvitations.SaveChanges();
        }
        public void DeletePayment(Payment payment)
        {
            MyDB.tblPayment.Delete(payment);
            MyDB.tblPayment.SaveChanges();
        }
        #endregion
        #region GetByCode Methods

        public SmallCategory GetSmallCategoryByCode(int codeSmallCategory)
        {
            return MyDB.tblSmallCategory.GetSmallCategoryByCode(codeSmallCategory);
        }
        public ItemsForSale GetCodeItemForSaleByCode(int codeItemForSale)
        {
            return MyDB.tblItemsForSale.GetItemsForSaleByCode(codeItemForSale);
        }
        public Category GetCategoryByCode(int codeCategory)
        {
            return MyDB.tblCategory.GetCategoryByCode(codeCategory);
        }
        public LevelI GetLevelByCode(int codeLevel)
        {
            return MyDB.tbllevel.GetLevelByCode(codeLevel);
        }
        public City GetCityByCode(int codeCity)
        {
            return MyDB.tblcity.GetCityByCode(codeCity);
        }
        public Sellers GetSellersByCode(string idSellers)
        {
            return MyDB.tblSellers.GetSellersById(idSellers);
        }
        public Customers GetcustomersByCode(string codeCustomer)
        {
            return MyDB.tblCustomers.GetCustomersByCode(codeCustomer);
        }
  
        public Favorites GetFavoritesByCode(int codeFavorite,string codeCustomer,int codeItemForSale)
        {
            return MyDB.tblFavorites.GetFavoriteByCode(codeFavorite,codeCustomer,codeItemForSale);
        }



        public AdvertisingLocation GetAdvertisingLocationByCode(int codeLocation)
        {
            return MyDB.tblAdvertisingLocation.GetLocationByCode(codeLocation);
        }
        public InvitationDescription GetInvitationDescriptionByCode(int codeInvitation)
        {
            return MyDB.tblinvitationDescription.GetInvitationDescriptionByCode(codeInvitation);
        }
        public AdvertistisingInvitations GetAdvertisingInvitationByCode(int codeInvitation)
        {
            return MyDB.tblAdvertisingInvitations.GetAdvertisingInvitationsByCode(codeInvitation);
        }
        public Payment GetPaymentByCode(int codePayment)
        {
            return MyDB.tblPayment.GetPaymentByCode(codePayment);
        }
        #endregion
        #region GetBySelect Methods

        public List<SmallCategory> GetSmallCategoryBySelect(string nameField, string st)
        {
            return MyDB.tblSmallCategory.GetListBySelect(nameField, st).Cast<SmallCategory>().ToList();
        }

        public List<ItemsForSale> GetItemsForSaleBySelect(string nameField, string st)
        {
            return MyDB.tblItemsForSale.GetListBySelect(nameField, st).Cast<ItemsForSale>().ToList();
        }
        public List<Category> GetCategoryBySelect(string nameField, string st)
        {
            return MyDB.tblCategory.GetListBySelect(nameField, st).Cast<Category>().ToList();
        }
        public List<LevelI> GetLevelBySelect(string nameField, string st)
        {
            return MyDB.tbllevel.GetListBySelect(nameField, st).Cast<LevelI>().ToList();
        }
        public List<City> GetCityBySelect(string nameField, string st)
        {
            return MyDB.tblCustomers.GetListBySelect(nameField, st).Cast<City>().ToList();
        }
        public List<Sellers> GetSellersBySelect(string nameField, string st)
        {
            return MyDB.tblSellers.GetListBySelect(nameField, st).Cast<Sellers>().ToList();
        }
        public List<Customers> GetCustomersBySelect(string nameField, string st)
        {
            return MyDB.tblCustomers.GetListBySelect(nameField, st).Cast<Customers>().ToList();
        }
      
        public List<Favorites> GetFavoritesBySelect(string nameField, string st)
        {
            return MyDB.tblFavorites.GetListBySelect(nameField, st).Cast<Favorites>().ToList();
        }
        public List<AdvertisingLocation> GetAdvertisingLocationBySelect(string nameField, string st)
        {
            return MyDB.tblAdvertisingLocation.GetListBySelect(nameField, st).Cast<AdvertisingLocation>().ToList();
        }
        public List<InvitationDescription> GetInvitationDescriptionBySelect(string nameField, string st)
        {
            return MyDB.tblinvitationDescription.GetListBySelect(nameField, st).Cast<InvitationDescription>().ToList();
        }
        public List<AdvertistisingInvitations> GetAdvertisingInvitationBySelect(string nameField, string st)
        {
            return MyDB.tblAdvertisingInvitations.GetListBySelect(nameField, st).Cast<AdvertistisingInvitations>().ToList();
        }
        public List<Payment> GetPaymentBySelect(string nameField, string st)
        {
            return MyDB.tblPayment.GetListBySelect(nameField, st).Cast<Payment>().ToList();
        }
        #endregion
        #region GetList Methods
 

        public List<ItemsForSale> GetListItemsForSaleForAYear()
        {
            return MyDB.tblItemsForSale.GetList().OrderBy(x => x.CodeItemForSale).ToList();
        }
        public List<Category> GetListCategory()
        {
            return MyDB.tblCategory.GetList().OrderBy(x => x.CodeCategory).ToList();
        }
        public List<SmallCategory> GetListSmallCategory()
        {
            return MyDB.tblSmallCategory.GetList().OrderBy(x => x.CodeSmallCategory).ToList();
        }
        public List<LevelI> GetListLevel()
        {
            return MyDB.tbllevel.GetList().OrderBy(x => x.CodeLevel).ToList();
        }
        public List<City> GetListCity()
        {
            return MyDB.tblcity.GetList().OrderBy(x => x.CodeCity).ToList();
        }
        public List<Sellers> GetListSellers()
        {
            return MyDB.tblSellers.GetList().OrderBy(x => x.IdSeller).ToList();
        }
        public List<Customers> GetListCustomers()
        {
            return MyDB.tblCustomers.GetList().OrderBy(x => x.CodeCustomer).ToList();
        }
  
        public List<Favorites> GetListFavorites()
        {
            return MyDB.tblFavorites.GetList() .OrderBy(x => x.CodeFavorite).ThenBy(x => x.CodeItemForSale).ThenBy(x => x.CodeCustomer) .ToList();
        }

        public List<AdvertisingLocation> GetListAdvertisingLocation()
        {
            return MyDB.tblAdvertisingLocation.GetList().OrderBy(x => x.CodeLocation).ToList();
        }
        public List<AdvertistisingInvitations> GetListAdvertisingInvitations()
        {
            return MyDB.tblAdvertisingInvitations.GetList().OrderBy(x => x.CodeInvitation).ToList();
        }
        public List<InvitationDescription> GetListInvitationDescription()
        {
            return MyDB.tblinvitationDescription.GetList().OrderBy(x => x.CodeInvitation.CodeInvitation).ToList();
        }
        public List<Payment> GetListPayment()
        {
            return MyDB.tblPayment.GetList().OrderBy(x => x.CodePayment).ToList();
        }
        #endregion
        #region UpDate Methods

        public void UpDateSmallCategory(SmallCategory smallCategory)
        {
            MyDB.tblSmallCategory.Update(smallCategory);
            MyDB.tblSmallCategory.SaveChanges();
        }
        public void UpDateItemForSale(ItemsForSale itemsForSale)
        {
            MyDB.tblItemsForSale.Update(itemsForSale);
            MyDB.tblItemsForSale.SaveChanges();
        }
        public void UpDateCategoty(Category category)
        {
            MyDB.tblCategory.Update(category);
            MyDB.tblCategory.SaveChanges();
        }
        public void UpDateLevel(LevelI level)
        {
            MyDB.tbllevel.Update(level);
            MyDB.tbllevel.SaveChanges();
        }
        public void UpDateCity(City city)
        {
            MyDB.tblcity.Update(city);
            MyDB.tblcity.SaveChanges();
        }
        public void UpDateSellers(Sellers sellers)
        {
            MyDB.tblSellers.Update(sellers);
            MyDB.tblSellers.SaveChanges();
        }
        public void UpDateCustomers(Customers customers)
        {
            MyDB.tblCustomers.Update(customers);
            MyDB.tblCustomers.SaveChanges();
        }

        public void UpDateFavorites(Favorites favorites)
        {
            MyDB.tblFavorites.Update(favorites);
            MyDB.tblFavorites.SaveChanges();
        }
        public void UpDateAdvertisingLocation(AdvertisingLocation advertisingLocation)
        {
            MyDB.tblAdvertisingLocation.Update(advertisingLocation);
            MyDB.tblAdvertisingLocation.SaveChanges();
        }
        public void UpDateInvitationDescription(InvitationDescription invitationDescription)
        {
            MyDB.tblinvitationDescription.Update(invitationDescription);
            MyDB.tblinvitationDescription.SaveChanges();
        }
        public void UpDateAdvertisingInvitation(AdvertistisingInvitations advertistisingInvitations)
        {
            MyDB.tblAdvertisingInvitations.Update(advertistisingInvitations);
            MyDB.tblAdvertisingInvitations.SaveChanges();
        }
        public void UpDatePayment(Payment payment)
        {
            MyDB.tblPayment.Update(payment);
            MyDB.tblPayment.SaveChanges();
        }

        #endregion
        #region GetNextKey Methods
        public int GetNextKeyCategory()
        {
            Category c = MyDB.tblCategory.GetList().OrderBy(x => x.CodeCategory).LastOrDefault();
            if (c == null)
                return 1;
            return c.CodeCategory + 1;
        }
        public int GetNextKeySmallCategory()
        {
            SmallCategory c = MyDB.tblSmallCategory.GetList().OrderBy(x => x.CodeSmallCategory).LastOrDefault();
            if (c == null)
                return 1;
            return c.CodeSmallCategory + 1;
        }
        public int GetNextKeyLevel()
        {
            LevelI c = MyDB.tbllevel.GetList().OrderBy(x => x.CodeLevel).LastOrDefault();
            if (c == null)
                return 1;
            return c.CodeLevel + 1;
        }
        public int GetNextKeyCity()
        {
            City c = MyDB.tblcity.GetList().OrderBy(x => x.CodeCity).LastOrDefault();
            if (c == null)
                return 1;
            return c.CodeCity + 1;
        }
        public int GetNextKeyAdvertisingLocation()
        {
            AdvertisingLocation c = MyDB.tblAdvertisingLocation.GetList().OrderBy(x => x.CodeLocation).LastOrDefault();
            if (c == null)
                return 1;
            return c.CodeLocation + 1;
        }
        public int GetNextKeyAdvertisingInvitation()
        {
            AdvertistisingInvitations c = MyDB.tblAdvertisingInvitations.GetList().OrderBy(x => x.CodeInvitation).LastOrDefault();
            if (c == null)
                return 1;
            return c.CodeInvitation + 1;
        }
        public int GetNextKeyItemForSale()
        {
            ItemsForSale c = MyDB.tblItemsForSale.GetList().OrderBy(x => x.CodeItemForSale).LastOrDefault();
            if (c == null)
                return 1;
            return c.CodeItemForSale + 1;
        }
        public int GetNextKeyFavorites()
        {
            Favorites c = MyDB.tblFavorites.GetList().OrderBy(x => x.CodeFavorite).LastOrDefault();
            if (c == null)
                return 1;
            return c.CodeFavorite + 1;
        }
        public int GetNextKeyPayment()
        {
            Payment p = MyDB.tblPayment.GetList().OrderBy(x => x.CodePayment).LastOrDefault();
            if (p == null)
                return 1;
            return p.CodePayment + 1;
        }
        #endregion

        #region Images
        public string GetCurrentPath()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            int x = path.IndexOf(@"\Host");
            path = path.Substring(0, x);

            return path;


        }

        public byte[] GetImage(string fileName)
        {
            string path = GetCurrentPath() + @"\Images\" + fileName;
            if (File.Exists(path))
            {
                return File.ReadAllBytes(path);
            }
            return null;
        }
        public void SaveImg(byte[] imageArr, string nameFile)
        {
            var stream = new MemoryStream(imageArr);
            System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
            string path = GetCurrentPath() + @"\Images\" + nameFile;
            img.Save(path);
        }
        #endregion
    }
}
