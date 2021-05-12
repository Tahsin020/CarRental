using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string AuthorizationDenied;

        public static string CarAdded="Araç eklendi";
        public static string CarDeleted="Araç silindi";
        public static string CarListed="Araçlar Listelendi";      
        public static string CarDetailListed="Araç detay listelendi";
        public static string CarUpdated="Araç bilgileri güncellendi";

        public static string BrandDeleted="Marka silindi";
        public static string BrandsListed="Markalar listelendi";
        public static string BrandUpdated="Marka Güncellendi";

        public static string ColorAdded="Renk eklendi";
        public static string ColorDeleted="Renk silindi";
        public static string ColorListed="Renkler Listelendi";
        public static string ColorUpdated="Renk güncellendi";

        public static string CustomerAdded="Müşteri Eklendi";
        public static string CustomerUpdated="Müşteri güncellendi";
        public static string CustomerDeleted="Müşteri silindi";
        public static string CustomersListed="Müşteriler Listelendi";

        public static string RentalAdded="Kiralama eklendi";
        public static string RentalListed="Kiralamalar Listelendi";
        public static string RentalDeleted="Kiralama silindi";
        public static string RentalUpdated="Kiralama güncellendi";
        
        public static string UserAdded="Kullanıcı eklendi";
        public static string UserUpdated="Kullanıcı güncellendi";
        public static string UserDeleted="Kullanici silindi";
        public static string BrandAdded="Marka Eklendi";        
       
        public static string CarNameAlreadyExists= "Araç Adı Zaten Mevcut";
        public static string BrandLimitExceded= "Marka Sınırı Aşıldı";
        public static string CarCountOfBrandError= "Araç Marka Sayısı Hatası";

        public static string ImageAdded="Resim eklendi";
        public static string ImageDeleted="Resim Silindi";
        public static string ImageListed="Resimler Listelendi";
        public static string ImageUpdated="Resim güncellendi";
        public static string CarImageLimit= "Araba Görüntü Sınırı";
    }
}
