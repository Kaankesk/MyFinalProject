using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductRemoved = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Bakım saati";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameExists = "Aynı isimde iki ürün olamaz";
        public static string CategoryAmountIsBiggerThanLimit = "Kategori sayısı limitten fazla";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı Kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Yanlış şifre girildi";
        public static string SuccessfulLogin = "Başarılı Giriş yapıldı";
        public static string UserAlreadyExists = "Böyle bir kullanıcı zaten bulunuyor";
        public static string AccessTokenCreated = "Token yaratıdı";
    }
}
