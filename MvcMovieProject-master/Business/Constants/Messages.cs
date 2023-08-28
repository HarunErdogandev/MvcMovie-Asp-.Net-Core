using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MovieAdded = "Film Eklendi";
        public static string MovieDeleted = "Film Silindi";
        public static string MovieUpdated = "Film Güncellendi";

        public static string MoviesListed = "Filmler Listelendi";
        public static string MovieListed = "Film Listelendi";

        public static string CategoryAdded = "Kategori Eklendi";
        public static string CategoryDeleted = "Kategori Silindi";
        public static string CategoryUpdated = "Kategori Güncellendi";

        public static string Categorylisted = "Kategori Listelendi";
        public static string Categorieslisted = "Kategoriler Listelendi";

        public static string MaintenanceTime = "Sistem Bakımda";
        public static string MovieNameAlreadyExists="Böyle bir film zaten var";
        internal static string? AuthorizationDenied="Yetkiniz yok";
    }
}
