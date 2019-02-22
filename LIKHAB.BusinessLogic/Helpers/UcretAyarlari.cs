using LIKHAB.DataLayer.DBContext;
using System.Collections.Generic;
using System.Linq;

namespace LIKHAB.BusinessLogic.Helpers
{
    public class UcretAyarlari
    {
        private LikhabDBContext _db;
        private static IEnumerable<LIKHAB.DataLayer.Models.UcretAyarlari> _ucretAyarlari;

        public UcretAyarlari()
        {
            _db = new LikhabDBContext();
            _ucretAyarlari = _db.UcretAyarlaris.ToList();
        }

        public static decimal Ucrt_01_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_01").Parametre;
        public static decimal Ucrt_01_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_02").Parametre;
        public static decimal Ucrt_01_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_03").Parametre;
        public static decimal Ucrt_01_04 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_04").Parametre;
        public static decimal Ucrt_01_05 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_05").Parametre;
        public static decimal Ucrt_01_06 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_06").Parametre;
        public static decimal Ucrt_01_07 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_07").Parametre;
        public static decimal Ucrt_01_08 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_08").Parametre;
        public static decimal Ucrt_01_09 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_09").Parametre;
        public static decimal Ucrt_01_10 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_10").Parametre;
        public static decimal Ucrt_01_11 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_11").Parametre;
        public static decimal Ucrt_01_12 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_12").Parametre;
        public static decimal Ucrt_01_13 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_13").Parametre;
        public static decimal Ucrt_01_14 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_01_14").Parametre;
        public static decimal Ucrt_02_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_02_01").Parametre;
        public static decimal Ucrt_04_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_04_01").Parametre;
        public static decimal Ucrt_04_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_04_02").Parametre;
        public static decimal Ucrt_04_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_04_03").Parametre;
        public static decimal Ucrt_04_04 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_04_04").Parametre;
        public static decimal Ucrt_04_05 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_04_05").Parametre;
        public static decimal Ucrt_04_06 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_04_06").Parametre;
        public static decimal Ucrt_05_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_05_01").Parametre;
        public static decimal Ucrt_06_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_06_01").Parametre;
        public static decimal Ucrt_06_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_06_02").Parametre;
        public static decimal Ucrt_07_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_07_01").Parametre;
        public static decimal Ucrt_08_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_08_01").Parametre;
        public static decimal Ucrt_08_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_08_02").Parametre;
        public static decimal Ucrt_08_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_08_03").Parametre;
        public static decimal Ucrt_08_04 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_08_04").Parametre;
        public static decimal Ucrt_08_05 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_08_05").Parametre;
        public static decimal Ucrt_08_06 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_08_06").Parametre;
        public static decimal Ucrt_08_07 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_08_07").Parametre;
        public static decimal Ucrt_11_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_11_01").Parametre;
        public static decimal Ucrt_11_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_11_02").Parametre;
        public static decimal Ucrt_11_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_11_03").Parametre;
        public static decimal Ucrt_12_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_12_01").Parametre;
        public static decimal Ucrt_12_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_12_02").Parametre;
        public static decimal Ucrt_12_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_12_03").Parametre;
        public static decimal Ucrt_12_04 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_12_04").Parametre;
        public static decimal Ucrt_12_05 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_12_05").Parametre;
        public static decimal Ucrt_13_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_13_01").Parametre;
        public static decimal Ucrt_13_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_13_02").Parametre;
        public static decimal Ucrt_13_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_13_03").Parametre;
        public static decimal Ucrt_14_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_14_01").Parametre;
        public static decimal Ucrt_14_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_14_02").Parametre;
        public static decimal Ucrt_14_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_14_03").Parametre;
        public static decimal Ucrt_14_04 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_14_04").Parametre;
        public static decimal Ucrt_14_05 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_14_05").Parametre;
        public static decimal Ucrt_14_06 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_14_06").Parametre;
        public static decimal Ucrt_14_07 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_14_07").Parametre;
        public static decimal Ucrt_14_08 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_14_08").Parametre;
        public static decimal Ucrt_15_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_15_01").Parametre;
        public static decimal Ucrt_15_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_15_02").Parametre;
        public static decimal Ucrt_15_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_15_03").Parametre;
        public static decimal Ucrt_15_04 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_15_04").Parametre;
        public static decimal Ucrt_15_05 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_15_05").Parametre;
        public static decimal Ucrt_15_06 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_15_06").Parametre;
        public static decimal Ucrt_15_07 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_15_07").Parametre;
        public static decimal Ucrt_15_08 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_15_08").Parametre;
        public static decimal Ucrt_15_09 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_15_09").Parametre;
        public static decimal Ucrt_16_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_01").Parametre;
        public static decimal Ucrt_16_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_02").Parametre;
        public static decimal Ucrt_16_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_03").Parametre;
        public static decimal Ucrt_16_04 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_04").Parametre;
        public static decimal Ucrt_16_05 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_05").Parametre;
        public static decimal Ucrt_16_06 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_06").Parametre;
        public static decimal Ucrt_16_07 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_07").Parametre;
        public static decimal Ucrt_16_08 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_08").Parametre;
        public static decimal Ucrt_16_09 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_09").Parametre;
        public static decimal Ucrt_16_10 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_10").Parametre;
        public static decimal Ucrt_16_11 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_11").Parametre;
        public static decimal Ucrt_16_12 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_16_12").Parametre;
        public static decimal Ucrt_17_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_17_01").Parametre;
        public static decimal Ucrt_17_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_17_02").Parametre;
        public static decimal Ucrt_17_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_17_03").Parametre;
        public static decimal Ucrt_18_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_18_01").Parametre;
        public static decimal Ucrt_18_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_18_02").Parametre;
        public static decimal Ucrt_18_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_18_03").Parametre;
        public static decimal Ucrt_20_01 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_20_01").Parametre;
        public static decimal Ucrt_20_02 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_20_02").Parametre;
        public static decimal Ucrt_20_03 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_20_03").Parametre;
        public static decimal Ucrt_20_04 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_20_04").Parametre;
        public static decimal Ucrt_20_05 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_20_05").Parametre;
        public static decimal Ucrt_20_06 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_20_06").Parametre;
        public static decimal Ucrt_20_07 => _ucretAyarlari.FirstOrDefault(c => c.UcretKodu == "ucrt_20_07").Parametre;
    }
}