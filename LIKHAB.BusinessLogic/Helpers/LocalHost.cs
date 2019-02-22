namespace LIKHAB.BusinessLogic.Helpers
{
    public struct LocalHost
    {
        public static string GetName() => "http://mezzanine74-001-site2.htempurl.com";

        public static string GetRandevuOnaySayfasi() => "Islemler/Randevu/RandevuOnayla";

        public static string GetIsBilgileriniGirSayfasi() => "Islemler/IsBilgileri/IsBilgileriniGir";

        public static string GetIslemlerJSONRandevular() => "/Islemler/JSON/Randevular/";

        public static string GetIslemlerJSONNotificationSendEmailAway() => "/Islemler/JSON/NotificationSendEmailAway/";

        public static string GetRandevuVeIlintiliBilgileriSilJSON() => "/Islemler/JSON/RandevuVeIlintiliBilgileriSil/";

        public static string GetIsIleIlintiliBilgileriSilJSON() => "/Islemler/JSON/IsIleIlintiliBilgileriSilJSON/";

        public static string GetRandevusuzOnaylaJSON() => "/Islemler/JSON/RandevusuzOnaylaJSON/";

        public static string GetRandevuOnayValidateJSON() => "/Islemler/JSON/RandevuOnayValidateJSON/";

        public static string GetSozlesmeRaporlariSayfasi() => "/Islemler/Raporlar/SozlesmeRaporu/";

        public static string GetTeslimRaporuSayfasi() => "/Islemler/Raporlar/TeslimSenedi/";

        public static string GetIsBilgileriEditPost() => "/Islemler/IsBilgileri/IsBilgileriEdit/";

        public static string GetProcessRolesUsers() => "/Admin/JSON/ProcessRolesUsers/";

    }
}