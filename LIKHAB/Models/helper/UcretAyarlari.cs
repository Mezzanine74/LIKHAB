//using System.Collections.Generic;
//using System.Linq;

//namespace LIKHAB.Models.helper
//{
//    public class UcretAyarlari
//    {
//        static LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities();

//        static IEnumerable<LIKHAB.Models.db.UcretAyarlari> ucretAyarlari = db.UcretAyarlari.ToList();

//        public static decimal ucrt_01_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_01").Parametre; }
//        public static decimal ucrt_01_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_02").Parametre; }
//        public static decimal ucrt_01_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_03").Parametre; }
//        public static decimal ucrt_01_04() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_04").Parametre; }
//        public static decimal ucrt_01_05() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_05").Parametre; }
//        public static decimal ucrt_01_06() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_06").Parametre; }
//        public static decimal ucrt_01_07() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_07").Parametre; }
//        public static decimal ucrt_01_08() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_08").Parametre; }
//        public static decimal ucrt_01_09() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_09").Parametre; }
//        public static decimal ucrt_01_10() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_10").Parametre; }
//        public static decimal ucrt_01_11() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_11").Parametre; }
//        public static decimal ucrt_01_12() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_12").Parametre; }
//        public static decimal ucrt_01_13() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_13").Parametre; }
//        public static decimal ucrt_01_14() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_01_14").Parametre; }
//        public static decimal ucrt_02_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_02_01").Parametre; }
//        public static decimal ucrt_04_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_04_01").Parametre; }
//        public static decimal ucrt_04_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_04_02").Parametre; }
//        public static decimal ucrt_04_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_04_03").Parametre; }
//        public static decimal ucrt_04_04() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_04_04").Parametre; }
//        public static decimal ucrt_04_05() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_04_05").Parametre; }
//        public static decimal ucrt_04_06() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_04_06").Parametre; }
//        public static decimal ucrt_05_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_05_01").Parametre; }
//        public static decimal ucrt_06_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_06_01").Parametre; }
//        public static decimal ucrt_06_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_06_02").Parametre; }
//        public static decimal ucrt_07_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_07_01").Parametre; }
//        public static decimal ucrt_08_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_08_01").Parametre; }
//        public static decimal ucrt_08_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_08_02").Parametre; }
//        public static decimal ucrt_08_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_08_03").Parametre; }
//        public static decimal ucrt_08_04() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_08_04").Parametre; }
//        public static decimal ucrt_08_05() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_08_05").Parametre; }
//        public static decimal ucrt_08_06() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_08_06").Parametre; }
//        public static decimal ucrt_08_07() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_08_07").Parametre; }
//        public static decimal ucrt_11_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_11_01").Parametre; }
//        public static decimal ucrt_11_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_11_02").Parametre; }
//        public static decimal ucrt_11_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_11_03").Parametre; }
//        public static decimal ucrt_12_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_12_01").Parametre; }
//        public static decimal ucrt_12_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_12_02").Parametre; }
//        public static decimal ucrt_12_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_12_03").Parametre; }
//        public static decimal ucrt_12_04() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_12_04").Parametre; }
//        public static decimal ucrt_12_05() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_12_05").Parametre; }
//        public static decimal ucrt_13_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_13_01").Parametre; }
//        public static decimal ucrt_13_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_13_02").Parametre; }
//        public static decimal ucrt_13_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_13_03").Parametre; }
//        public static decimal ucrt_14_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_14_01").Parametre; }
//        public static decimal ucrt_14_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_14_02").Parametre; }
//        public static decimal ucrt_14_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_14_03").Parametre; }
//        public static decimal ucrt_14_04() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_14_04").Parametre; }
//        public static decimal ucrt_14_05() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_14_05").Parametre; }
//        public static decimal ucrt_14_06() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_14_06").Parametre; }
//        public static decimal ucrt_14_07() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_14_07").Parametre; }
//        public static decimal ucrt_14_08() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_14_08").Parametre; }
//        public static decimal ucrt_15_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_15_01").Parametre; }
//        public static decimal ucrt_15_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_15_02").Parametre; }
//        public static decimal ucrt_15_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_15_03").Parametre; }
//        public static decimal ucrt_15_04() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_15_04").Parametre; }
//        public static decimal ucrt_15_05() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_15_05").Parametre; }
//        public static decimal ucrt_15_06() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_15_06").Parametre; }
//        public static decimal ucrt_15_07() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_15_07").Parametre; }
//        public static decimal ucrt_15_08() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_15_08").Parametre; }
//        public static decimal ucrt_15_09() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_15_09").Parametre; }
//        public static decimal ucrt_16_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_01").Parametre; }
//        public static decimal ucrt_16_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_02").Parametre; }
//        public static decimal ucrt_16_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_03").Parametre; }
//        public static decimal ucrt_16_04() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_04").Parametre; }
//        public static decimal ucrt_16_05() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_05").Parametre; }
//        public static decimal ucrt_16_06() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_06").Parametre; }
//        public static decimal ucrt_16_07() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_07").Parametre; }
//        public static decimal ucrt_16_08() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_08").Parametre; }
//        public static decimal ucrt_16_09() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_09").Parametre; }
//        public static decimal ucrt_16_10() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_10").Parametre; }
//        public static decimal ucrt_16_11() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_11").Parametre; }
//        public static decimal ucrt_16_12() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_16_12").Parametre; }
//        public static decimal ucrt_17_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_17_01").Parametre; }
//        public static decimal ucrt_17_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_17_02").Parametre; }
//        public static decimal ucrt_17_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_17_03").Parametre; }
//        public static decimal ucrt_18_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_18_01").Parametre; }
//        public static decimal ucrt_18_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_18_02").Parametre; }
//        public static decimal ucrt_18_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_18_03").Parametre; }
//        public static decimal ucrt_20_01() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_20_01").Parametre; }
//        public static decimal ucrt_20_02() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_20_02").Parametre; }
//        public static decimal ucrt_20_03() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_20_03").Parametre; }
//        public static decimal ucrt_20_04() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_20_04").Parametre; }
//        public static decimal ucrt_20_05() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_20_05").Parametre; }
//        public static decimal ucrt_20_06() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_20_06").Parametre; }
//        public static decimal ucrt_20_07() { return ucretAyarlari.First(c => c.UcretKodu == "ucrt_20_07").Parametre; }

//    }
//}