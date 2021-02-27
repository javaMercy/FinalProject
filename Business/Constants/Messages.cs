using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Bakım Arası";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string OverOfCategoryCount = "Bir kategoride en fazla 10 ürün olabilir!";
        public static string ProductNameAlreadyExists = "Böyle bir ürün ismi zaten mevcut!";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor!";
    }
}
