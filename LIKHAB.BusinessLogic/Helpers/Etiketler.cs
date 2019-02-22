using System.Collections.Generic;
using System.Drawing;

namespace LIKHAB.BusinessLogic.Helpers
{
    public struct Etiketler
    {
        public static string OnayaGonderilmedi => "Onaya Gonderilmedi";
        public static string OnayBekliyor => "Onay Bekliyor";
        public static string IsYapilmadi => "Is Yapilmadi";
        public static string IsKapandi => "Is Kapandi";

        public static List<EtiketElemani> RandevuEtiketListesi => new List<EtiketElemani>()
            {
                new EtiketElemani { Id = 1, DisplayName = OnayaGonderilmedi, MenuCaption = OnayaGonderilmedi, Color = Color.LightGray },
                new EtiketElemani { Id = 2, DisplayName = OnayBekliyor, MenuCaption = OnayBekliyor, Color = Color.Yellow },
                new EtiketElemani { Id = 3, DisplayName = IsYapilmadi, MenuCaption = IsYapilmadi, Color = Color.Red },
                new EtiketElemani { Id = 4, DisplayName = IsKapandi, MenuCaption = IsKapandi, Color = Color.Green }
            };
    }

}