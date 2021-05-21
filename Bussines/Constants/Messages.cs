using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakım zamanı.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten bir ürün mevcuttur";
        public static string CategoryLimitExceded= "Kategori limiti aşıldı."  ;
        public static string AuthorizationDenied = "Yetkiniz yok."  ;
        public static string UserRegistered = "Kayıt bulunamadı.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı parola.";
        public static string SuccessfulLogin = "Kayıt başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated  =  " Token oluşturuldu";
    }
}
