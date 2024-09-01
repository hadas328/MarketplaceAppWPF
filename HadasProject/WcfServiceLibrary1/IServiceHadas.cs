using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    [ServiceContract]
    public interface IServiceHadas
    {
        [OperationContract]

        void AddItemsForSale(ItemsForSale itemsForSale);
        [OperationContract]
        void AddCategory(Category category);
        [OperationContract]
        void AddSmallCategory(SmallCategory smallCategory);
        [OperationContract]
        void AddLevel(LevelI level);

        [OperationContract]
        void AddCity(City city);

        [OperationContract]
        void AddSellers(Sellers sellers);
        [OperationContract]
        void AddCustomers(Customers customers);
        [OperationContract]
 
        void AddFavorite(Favorites favorites);
        [OperationContract]
        void AddAdvertisingLocation(AdvertisingLocation advertisingLocation);
        [OperationContract]
        void AddInvitationDescription(InvitationDescription invitationDescription);
        [OperationContract]
        void AddAdvertisingInvitations(AdvertistisingInvitations advertistisingInvitations);
        [OperationContract]
        void AddPayment(Payment payment);
        [OperationContract]
 
        void DelItemForSale(ItemsForSale itemsForSale);
        [OperationContract]
        void DeleteCategory(Category category);
        [OperationContract]
        void DeleteSmallCategory(SmallCategory smallCategory);
        [OperationContract]
        void DelLevel(LevelI level);
        [OperationContract]
        void DelCity(City city);

        [OperationContract]
        void DeleteSellers(Sellers sellers);
        [OperationContract]
        void DelCustomers(Customers customers);
        [OperationContract]
  
        void DeleteFavorites(Favorites favorites);
        [OperationContract]
        void DelAdvertisingLocation(AdvertisingLocation advertisingLocation);
        [OperationContract]
        void DeleteInvitationDescription(InvitationDescription invitationDescription);
        [OperationContract]
        void DelAdvertisingInvitations(AdvertistisingInvitations advertistisingInvitations);
        [OperationContract]
        void DeletePayment(Payment payment);
        [OperationContract]
  
        ItemsForSale GetCodeItemForSaleByCode(int codeItemForSale);
        [OperationContract]
        Category GetCategoryByCode(int codeCategory);
        [OperationContract]
        SmallCategory GetSmallCategoryByCode(int codeSmallCategory);
        [OperationContract]
        LevelI GetLevelByCode(int codeLevel);
        [OperationContract]
        City GetCityByCode(int codeCity);
        [OperationContract]
        Sellers GetSellersByCode(string idSellers);
        [OperationContract]
        Customers GetcustomersByCode(string codeCustomer);
        [OperationContract]

        Favorites GetFavoritesByCode(int codeFavorite, string codeCustomer, int codeItemForSale);
        [OperationContract]

        AdvertisingLocation GetAdvertisingLocationByCode(int codeLocation);
        [OperationContract]
        InvitationDescription GetInvitationDescriptionByCode(int codeInvitation);
        [OperationContract]
        AdvertistisingInvitations GetAdvertisingInvitationByCode(int codeInvitation);
        [OperationContract]
        Payment GetPaymentByCode(int codePayment);
        [OperationContract]
    
        List<SmallCategory> GetSmallCategoryBySelect(string nameField, string st);
        [OperationContract]

        List<ItemsForSale> GetItemsForSaleBySelect(string nameField, string st);
        [OperationContract]
        List<Category> GetCategoryBySelect(string nameField, string st);
        [OperationContract]
        List<LevelI> GetLevelBySelect(string nameField, string st);

        [OperationContract]
        List<City> GetCityBySelect(string nameField, string st);
        [OperationContract]
        List<Sellers> GetSellersBySelect(string nameField, string st);
        [OperationContract]
        List<Customers> GetCustomersBySelect(string nameField, string st);
        [OperationContract]

 
        List<Favorites> GetFavoritesBySelect(string nameField, string st);
        [OperationContract]
        List<AdvertisingLocation> GetAdvertisingLocationBySelect(string nameField, string st);
        [OperationContract]
        List<InvitationDescription> GetInvitationDescriptionBySelect(string nameField, string st);
        [OperationContract]
        List<AdvertistisingInvitations> GetAdvertisingInvitationBySelect(string nameField, string st);
        [OperationContract]
        List<Payment> GetPaymentBySelect(string nameField, string st);
        [OperationContract]
 
        List<SmallCategory> GetListSmallCategory();
        [OperationContract]
        List<ItemsForSale> GetListItemsForSaleForAYear();
        [OperationContract]
        List<Category> GetListCategory();
        [OperationContract]
        List<LevelI> GetListLevel();
        [OperationContract]
        void UpDateCity(City city);
        [OperationContract]
        List<City> GetListCity();
        [OperationContract]
        List<Sellers> GetListSellers();
        [OperationContract]
        List<Customers> GetListCustomers();
        [OperationContract]

        List<Favorites> GetListFavorites();
        [OperationContract]

        List<AdvertisingLocation> GetListAdvertisingLocation();
        [OperationContract]
        List<InvitationDescription> GetListInvitationDescription();
        [OperationContract]
        List<AdvertistisingInvitations> GetListAdvertisingInvitations();
        [OperationContract]
        List<Payment> GetListPayment();
        [OperationContract]

 
        void UpDateSmallCategory(SmallCategory smallCategory);
        [OperationContract]
        void UpDateItemForSale(ItemsForSale itemsForSale);
        [OperationContract]
        void UpDateCategoty(Category category);
        [OperationContract]
        void UpDateLevel(LevelI level);
        [OperationContract]
        void UpDateSellers(Sellers sellers);
        [OperationContract]
        void UpDateCustomers(Customers customers);
        [OperationContract]
  
        void UpDateFavorites(Favorites favorites);
        [OperationContract]

        void UpDateAdvertisingLocation(AdvertisingLocation advertisingLocation);
        [OperationContract]
        void UpDateInvitationDescription(InvitationDescription invitationDescription);
        [OperationContract]
        void UpDateAdvertisingInvitation(AdvertistisingInvitations advertistisingInvitations);
        [OperationContract]
        void UpDatePayment(Payment payment);
        [OperationContract]
        int GetNextKeyCategory();
        [OperationContract]
        int GetNextKeySmallCategory();
        [OperationContract]
        int GetNextKeyLevel();
        [OperationContract]
        int GetNextKeyCity();
        [OperationContract]
        int GetNextKeyAdvertisingLocation();
        [OperationContract]
        int GetNextKeyAdvertisingInvitation();
        [OperationContract]
        int GetNextKeyItemForSale();
        [OperationContract]
        int GetNextKeyFavorites();
        [OperationContract]


        byte[] GetImage(string fileName);

        [OperationContract]
        void SaveImg(byte[] imageArr, string nameFile);
        [OperationContract]
        string GetCurrentPath();
        [OperationContract]
        int GetNextKeyPayment();




    }
}
