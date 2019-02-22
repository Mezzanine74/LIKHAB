//using LIKHAB.Models.helper;
//using System;
//using System.Linq;

//namespace LIKHAB.Codes.Helpers
//{
//    public class IsTuruMaddeleri
//    {
//        public static int ImarPlani() { return 1; }
//        public static int MucahirIci() { return 2; }
//        public static int MucahirDisi() { return 3; }
//    }

//    public class IsinCinsiMaddeleri
//    {
//        public static int aplikasyon() { return 1; }
//        public static int aplikasyonaltiayiçindeayniyerekrokitalebi() { return 2; }
//        public static int birlestirme() { return 4; }
//        public static int cinsdegisikligiayniyapiuzerindekatilavesi() { return 5; }
//        public static int cinsdegisikligibinayapimiveyikimiileilgiliolmayanvasifdonusturulmesi() { return 6; }
//        public static int cinsdegisikligiyapiliikenyapisizhalegelmesayiligenelge() { return 7; }
//        public static int cinsdegisikligiyapisizikenyapilihalegelme() { return 8; }
//        public static int hatalibagimsizduzeltmeislemi() { return 11; }
//        public static int irtifakhakki() { return 12; }
//        public static int kadastralyolsinirlarininbelirlenmesi() { return 13; }
//        public static int roperlikroki() { return 14; }
//        public static int vaziyetplanibagimsizbolumplani() { return 15; }
//        public static int yapiapplikasyonprojesi() { return 16; }
//        public static int yergostermebagimsizbolum() { return 17; }
//        public static int yergostermeparsel() { return 18; }
//    }

//    public class HesapModeli
//    {
//        public int isinCinsi { get; set; }
//        public int isTuru { get; set; }
//        public int binaSayisi { get; set; }
//        public decimal odaKatsayi { get; set; }
//        public int parselSayisi { get; set; }
//        public bool yuzde50CarpanUygula { get; set; }
//        public bool ayniKisiyeAit { get; set; }
//        public int bagimsizBolumSayisi { get; set; }
//        public decimal parselAlani { get; set; }
//        public int aplikasyonKrokisiSayisi { get; set; }
//        public bool araziyeGidilecekmi { get; set; }
//        public decimal b_Bolum { get; set; }
//        public decimal binaTabanAlani { get; set; }
//        public decimal insaatAlani { get; set; }
//        public int katSayisi { get; set; }
//        public int noktaSayisi { get; set; }
//        public bool odaBirimFiyatlariniKullan { get; set; }
//        public decimal yuzOlcumu { get; set; }
//        public decimal ik { get; set; }
//    }

//    public class UcretDokumuHesabi
//    {
//        static LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities();

//        // Once Genel Toplami alir
//        public decimal hesapSonucunuAl(HesapModeli hesap)
//        {

//            //1	APLİKASYON
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.aplikasyon())
//            {
//                return Math.Round(applikasyonHesapla(hesap.yuzOlcumu, hesap.isTuru, hesap.ik), 2, MidpointRounding.AwayFromZero);
//            };
//            //2	APLİKASYON / ALTI AY İÇİNDE AYNI YERE KROKI TALEBİ
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.aplikasyonaltiayiçindeayniyerekrokitalebi())
//            {
//                return Math.Round(aplikasyonaltiayiçindeayniyerekrokitalebiHesapla(hesap.aplikasyonKrokisiSayisi), 2, MidpointRounding.AwayFromZero);
//            };
//            //4	BIRLESTIRME
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.birlestirme())
//            {
//                return Math.Round(birlestirmeHesapla(hesap.parselSayisi, hesap.isTuru, hesap.ik), 2, MidpointRounding.AwayFromZero);
//            };
//            //5	CINS DEGISIKLIGI / AYNI YAPI UZERINDE KAT ILAVESI
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.cinsdegisikligiayniyapiuzerindekatilavesi())
//            {
//                return Math.Round(cinsdegisikligiayniyapiuzerindekatilavesiHesapla(), 2, MidpointRounding.AwayFromZero);
//            };
//            //6	CINS DEGISIKLIGI / BINA YAPIMI VE YIKIMI ILE ILGILI OLMAYAN VASIF DONUSTURULMESI
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.cinsdegisikligibinayapimiveyikimiileilgiliolmayanvasifdonusturulmesi())
//            {
//                return Math.Round(cinsdegisikligibinayapimiveyikimiileilgiliolmayanvasifdonusturulmesiHesapla(hesap.araziyeGidilecekmi), 2, MidpointRounding.AwayFromZero);
//            };
//            //7	CINS DEGISIKLIGI / YAPILI IKEN YAPISIZ HALE GELME (2010 / 4 SAYILI GENELGE)
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.cinsdegisikligiyapiliikenyapisizhalegelmesayiligenelge())
//            {
//                return Math.Round(cinsdegisikligiyapiliikenyapisizhalegelme20104sayiligenelgeHesapla(), 2, MidpointRounding.AwayFromZero);
//            };
//            //8	CINS DEGISIKLIGI / YAPISIZ IKEN YAPILI HALE GELME
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.cinsdegisikligiyapisizikenyapilihalegelme())
//            {
//                return Math.Round(cinsdegisikligiyapisizikenyapilihalegelmeHesapla(hesap.insaatAlani, hesap.binaSayisi, hesap.ik, hesap.isTuru), 2, MidpointRounding.AwayFromZero);
//            };
//            //11	HATALI BAGIMSIZ DUZELTME ISLEMI
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.hatalibagimsizduzeltmeislemi())
//            {
//                return Math.Round(hatalibagimsizduzeltmeislemiHesapla(hesap.bagimsizBolumSayisi), 2, MidpointRounding.AwayFromZero);
//            };
//            //12	IRTIFAK HAKKI
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.irtifakhakki())
//            {
//                return Math.Round(irtifakhakkiHesapla(hesap.parselSayisi, hesap.ik, hesap.isTuru), 2, MidpointRounding.AwayFromZero);
//            };
//            //13	KADASTRAL YOL SINIRLARININ BELIRLENMESI
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.kadastralyolsinirlarininbelirlenmesi())
//            {
//                return Math.Round(kadastralyolsinirlarininbelirlenmesiHesapla(hesap.noktaSayisi), 2, MidpointRounding.AwayFromZero);
//            };
//            //14	ROPERLI KROKI
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.roperlikroki())
//            {
//                return Math.Round(roperlikrokiHesapla(hesap.isTuru, hesap.ik, hesap.parselAlani, hesap.binaSayisi, hesap.odaBirimFiyatlariniKullan, hesap.odaKatsayi, hesap.yuzde50CarpanUygula), 2, MidpointRounding.AwayFromZero);
//            };
//            //15	VAZIYET PLANI, BAGIMSIZ BOLUM PLANI
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.vaziyetplanibagimsizbolumplani())
//            {
//                return Math.Round(vaziyetplanibagimsizbolumplaniHesapla(hesap.parselAlani, hesap.binaSayisi, hesap.katSayisi, hesap.b_Bolum, hesap.odaKatsayi, hesap.yuzde50CarpanUygula), 2, MidpointRounding.AwayFromZero);
//            };
//            //16	YAPI APPLIKASYON PROJESI
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.yapiapplikasyonprojesi())
//            {
//                return Math.Round(yapiapplikasyonprojesiHesapla(hesap.binaTabanAlani, hesap.binaSayisi, hesap.odaKatsayi, hesap.yuzde50CarpanUygula), 2, MidpointRounding.AwayFromZero);
//            };
//            //17	YER GOSTERME / BAGIMSIZ BOLUM
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.yergostermebagimsizbolum())
//            {
//                return Math.Round(yergostermebagimsizbolumHesapla(hesap.bagimsizBolumSayisi, hesap.ayniKisiyeAit), 2, MidpointRounding.AwayFromZero);
//            };
//            //18	YER GOSTERME / PARSEL
//            if (hesap.isinCinsi == IsinCinsiMaddeleri.yergostermeparsel())
//            {
//                return Math.Round(yergostermeparselHesapla(hesap.parselSayisi, hesap.ayniKisiyeAit), 2, MidpointRounding.AwayFromZero);
//            };

//            return 0;
//        }

//        // Genel Toplamin yukarda hesaplanmis haliyle icinde bulundugu UcretDokum modeli son hali icin islenir, STOPAJ ve TEVKIFAT burada girilmistir ancak son seklini bu blokta alir
//        public static LIKHAB.Models.db.UcretDokumu Hesapla(LIKHAB.Models.db.UcretDokumu record)
//        {

//            // genel Toplam sifir gonderilmisse, tum gridi sifirla ve geri gonder
//            if (Convert.ToDecimal(record.GenelToplam) == 0)
//            {
//                record.YolUcreti = Math.Round(Convert.ToDecimal(0), 2);
//                record.DenetimUcreti = Math.Round(Convert.ToDecimal(0), 2);
//                record.DamgaVergisi = Math.Round(Convert.ToDecimal(0), 2);
//                record.BelgeUcreti = Math.Round(Convert.ToDecimal(0), 2);
//                record.KontrolUcreti = Math.Round(Convert.ToDecimal(0), 2);
//                record.Toplam = Math.Round(Convert.ToDecimal(0), 2);
//                record.ToplamBrutUcret = Math.Round(Convert.ToDecimal(0), 2);
//                record.Stopaj20percent = Math.Round(Convert.ToDecimal(0), 2);
//                record.KesintilerToplami = Math.Round(Convert.ToDecimal(0), 2);
//                record.GenelToplam = Math.Round(Convert.ToDecimal(0), 2);
//                record.KDV18percent = Math.Round(Convert.ToDecimal(0), 2);
//                record.TevkifEdilenKDV = Math.Round(Convert.ToDecimal(0), 2);
//                record.TahsilEdilenKDV = Math.Round(Convert.ToDecimal(0), 2);
//                record.NetAlinan = Math.Round(Convert.ToDecimal(0), 2);
//                record.AlinacakGenelToplam = Math.Round(Convert.ToDecimal(0), 2);
//                return record;
//            };

//            decimal genelToplam_ilkdeger = 0; // Belge Ucreti ve Kontrol Ucreti icin gereklidir

//            // 1) FATURA KALEMLERI

//            // genel toplami yuvarla
//            record.GenelToplam = Math.Round(Convert.ToDecimal(record.GenelToplam), 2, MidpointRounding.AwayFromZero);
//            genelToplam_ilkdeger = Math.Round(Convert.ToDecimal(record.GenelToplam), 2, MidpointRounding.AwayFromZero);

//            // kdv'yi hesaplat
//            record.KDV18percent = Math.Round(Convert.ToDecimal(record.GenelToplam) - Convert.ToDecimal(record.GenelToplam) / Convert.ToDecimal(1.18), 2, MidpointRounding.AwayFromZero);

//            // toplam brut ucreti hesaplat
//            record.ToplamBrutUcret = Math.Round(Convert.ToDecimal(record.GenelToplam) / Convert.ToDecimal(1.18), 2, MidpointRounding.AwayFromZero);

//            // stopaji hesaplat, stopaj secili ise javascriptten 1 geliyor
//            if (Convert.ToDecimal(record.Stopaj20percent) > 0) { record.Stopaj20percent = Math.Round(Convert.ToDecimal(record.ToplamBrutUcret) * Convert.ToDecimal(0.20), 2, MidpointRounding.AwayFromZero); }
//            else
//            {
//                record.Stopaj20percent = Math.Round(Convert.ToDecimal(0), 2, MidpointRounding.AwayFromZero);
//            };

//            // kesintiler toplamini hesapla
//            record.KesintilerToplami = Math.Round(Convert.ToDecimal(record.Stopaj20percent), 2, MidpointRounding.AwayFromZero);

//            decimal tevkifatOrani = db.UcretAyarlari.Where(c => c.UcretKodu == HelperClasses.Enums.ucretKodu.ucrt_20_04.ToString()).ToList()[0].Parametre;

//            // tevkifat varsa
//            if (Convert.ToDecimal(record.TevkifEdilenKDV) > 0)
//            {
//                record.TevkifEdilenKDV = Math.Round(Convert.ToDecimal(record.KDV18percent) * Convert.ToDecimal(tevkifatOrani) / 10, 2, MidpointRounding.AwayFromZero);
//                record.TahsilEdilenKDV = Math.Round(Convert.ToDecimal(record.KDV18percent) * Convert.ToDecimal(10 - tevkifatOrani) / 10, 2, MidpointRounding.AwayFromZero);

//                // genel toplam degisir
//                record.GenelToplam -= record.TevkifEdilenKDV;

//                // stopaj etkeni
//                if (Convert.ToDecimal(record.Stopaj20percent) > 0)
//                {
//                    // net alinani hesaplat
//                    record.NetAlinan = Math.Round(Convert.ToDecimal(record.ToplamBrutUcret) + Convert.ToDecimal(record.TahsilEdilenKDV) - Convert.ToDecimal(record.Stopaj20percent), 2, MidpointRounding.AwayFromZero);
//                }
//                else
//                {
//                    // net alinani hesaplat
//                    record.NetAlinan = Math.Round(Convert.ToDecimal(record.GenelToplam), 2, MidpointRounding.AwayFromZero);
//                };
//            }
//            else
//            {
//                record.TevkifEdilenKDV = 0;
//                record.TahsilEdilenKDV = 0;

//                // genel toplam degismez

//                // stopaj etkeni
//                if (Convert.ToDecimal(record.Stopaj20percent) > 0)
//                {
//                    // net alinani hesaplat
//                    record.NetAlinan = Math.Round(Convert.ToDecimal(record.GenelToplam) - Convert.ToDecimal(record.TevkifEdilenKDV) - Convert.ToDecimal(record.Stopaj20percent), 2, MidpointRounding.AwayFromZero);
//                }
//                else
//                {
//                    // net alinani hesaplat
//                    record.NetAlinan = Math.Round(Convert.ToDecimal(record.GenelToplam), 2, MidpointRounding.AwayFromZero);
//                };

//            };

//            // 2) TAHSİLAT KALEMLERİ:

//            // Yol Ucreti
//            record.YolUcreti = Math.Round(Convert.ToDecimal(record.YolUcreti), 2, MidpointRounding.AwayFromZero); // burada olmazsa empty stringler sifira donmuyor

//            // Damga vergisi
//            decimal damgaVergisiUcretKatsayisi = db.UcretAyarlari.Where(c => c.UcretKodu == HelperClasses.Enums.ucretKodu.ucrt_20_03.ToString()).ToList()[0].Parametre;
//            decimal damgaVergisiEkUcreti = db.UcretAyarlari.Where(c => c.UcretKodu == HelperClasses.Enums.ucretKodu.ucrt_20_02.ToString()).ToList()[0].Parametre;

//            if (Convert.ToDecimal(record.DamgaVergisi) == 0)
//            {
//                //Toplam Brut Ucret * 0.00948 (Binde 9.48, ayarlardan gelecek)
//                record.DamgaVergisi = Math.Round(damgaVergisiUcretKatsayisi * Convert.ToDecimal(record.ToplamBrutUcret), 2, MidpointRounding.AwayFromZero);
//            }
//            else if (Convert.ToDecimal(record.DamgaVergisi) > 0) // Kadastroya Asli Gibi Verilecek secili, 0.65 TL gelecek (ucret ayarlarindan)
//            {
//                record.DamgaVergisi = Math.Round(damgaVergisiUcretKatsayisi * Convert.ToDecimal(record.ToplamBrutUcret) + damgaVergisiEkUcreti, 2, MidpointRounding.AwayFromZero);
//            };

//            // Belge Ucreti ve KontrolUcreti
//            decimal belgeUcretikatsayisi = db.UcretAyarlari.Where(c => c.UcretKodu == HelperClasses.Enums.ucretKodu.ucrt_20_05.ToString()).ToList()[0].Parametre,
//                    kontrolUcretiKatsayisi = db.UcretAyarlari.Where(c => c.UcretKodu == HelperClasses.Enums.ucretKodu.ucrt_20_06.ToString()).ToList()[0].Parametre;

//            if (Convert.ToDecimal(record.BelgeUcreti) > 0) // 1 degeri geliyor demektir
//            {
//                //Belge Ucreti > BU = GenelToplam * 0.05 (0.05 ayarlardan gelecek, %5)
//                record.BelgeUcreti = Math.Round(genelToplam_ilkdeger * belgeUcretikatsayisi, 2, MidpointRounding.AwayFromZero);
//            }
//            else
//            {
//                record.BelgeUcreti = Math.Round(Convert.ToDecimal(0), 2, MidpointRounding.AwayFromZero);
//            };

//            if (Convert.ToDecimal(record.KontrolUcreti) > 0) // 1 degeri geliyor demektir
//            {
//                //Kontrol Ucreti > BU = GenelToplam * 0.05 (0.05 ayarlardan gelecek, %5)
//                record.KontrolUcreti = Math.Round(genelToplam_ilkdeger * kontrolUcretiKatsayisi, 2, MidpointRounding.AwayFromZero);
//            }
//            else
//            {
//                record.KontrolUcreti = Math.Round(Convert.ToDecimal(0), 2, MidpointRounding.AwayFromZero);
//            };

//            // Denetim ucreti
//            var denetimParametresi = db.UcretAyarlari.Where(c => c.UcretKodu == HelperClasses.Enums.ucretKodu.ucrt_20_07.ToString()).ToList()[0];
//            record.DenetimUcreti = denetimParametresi.Kullan == true ? Math.Round(denetimParametresi.Parametre, 2, MidpointRounding.AwayFromZero) : Math.Round(Convert.ToDecimal(0), 2, MidpointRounding.AwayFromZero);

//            // Tahsilat Kalemleri Toplami
//            record.Toplam = Math.Round(
//                  Convert.ToDecimal(record.YolUcreti)
//                + Convert.ToDecimal(record.DenetimUcreti)
//                + Convert.ToDecimal(record.DamgaVergisi)
//                + Convert.ToDecimal(record.BelgeUcreti)
//                + Convert.ToDecimal(record.KontrolUcreti)
//                , 2, MidpointRounding.AwayFromZero);

//            // ***********************
//            // Genel toplam
//            record.AlinacakGenelToplam = Math.Round(Convert.ToDecimal(record.Toplam) + Convert.ToDecimal(record.NetAlinan), 2, MidpointRounding.AwayFromZero);

//            // return 
//            return record;
//        }

//        //APLİKASYON 
//        public decimal applikasyonHamDeger(decimal yuzolcumu)
//        {

//            if (yuzolcumu > 0 && yuzolcumu <= 1000) return UcretAyarlari.ucrt_01_01();
//            if (yuzolcumu > 1000 && yuzolcumu <= 3000) return UcretAyarlari.ucrt_01_02();
//            if (yuzolcumu > 3000 && yuzolcumu <= 5000) return UcretAyarlari.ucrt_01_03();
//            if (yuzolcumu > 5000 && yuzolcumu <= 10000) return UcretAyarlari.ucrt_01_04();
//            if (yuzolcumu > 10000 && yuzolcumu <= 20000) return UcretAyarlari.ucrt_01_05();
//            if (yuzolcumu > 20000 && yuzolcumu <= 50000) return UcretAyarlari.ucrt_01_06();
//            if (yuzolcumu > 50000 && yuzolcumu <= 100000) return UcretAyarlari.ucrt_01_07();
//            if (yuzolcumu > 100000 && yuzolcumu <= 200000) return UcretAyarlari.ucrt_01_08();
//            if (yuzolcumu > 200000 && yuzolcumu <= 500000) return UcretAyarlari.ucrt_01_09();
//            if (yuzolcumu > 500000) return UcretAyarlari.ucrt_01_09() + (Math.Truncate((yuzolcumu - 500000) / 100000) + 1) * UcretAyarlari.ucrt_01_10();
//            return 0;
//        }

//        public decimal applikasyonIsTuruDegeriyle(decimal hamDeger, int isTuru, decimal ik)
//        {
//            decimal _return = 0;
//            if (isTuru == IsTuruMaddeleri.ImarPlani()) { _return = hamDeger * ik * UcretAyarlari.ucrt_01_11(); return _return; } // Is Turu - Imar P
//            if (isTuru == IsTuruMaddeleri.MucahirIci()) return hamDeger * ik * UcretAyarlari.ucrt_01_12(); // Is Turu - Much, ici
//            if (isTuru == IsTuruMaddeleri.MucahirDisi()) return hamDeger * ik * UcretAyarlari.ucrt_01_13(); // Is turu - Much disi

//            return _return;
//        }

//        public decimal applikasyonHesapla(decimal yuzolcumu, int isTuru, decimal ik)
//        {
//            decimal result = applikasyonIsTuruDegeriyle(applikasyonHamDeger(yuzolcumu), isTuru, ik);

//            if (result > 0 && result < UcretAyarlari.ucrt_01_14())
//            {
//                return UcretAyarlari.ucrt_01_14();
//            }

//            return result;

//        }

//        // APLİKASYON / ALTI AY İÇİNDE AYNI YERE KROKI TALEBİ
//        public decimal aplikasyonaltiayiçindeayniyerekrokitalebiHamDeger(int aplikasyonKrokisiSayisi)
//        {
//            return aplikasyonKrokisiSayisi * UcretAyarlari.ucrt_02_01();
//        }

//        public decimal aplikasyonaltiayiçindeayniyerekrokitalebiHesapla(int aplikasyonKrokisiSayisi)
//        {
//            return aplikasyonaltiayiçindeayniyerekrokitalebiHamDeger(aplikasyonKrokisiSayisi);
//        }

//        // BIRLESTIRME
//        public decimal birlestirmeHamDeger(int parselSayisi)
//        {
//            if (parselSayisi < UcretAyarlari.ucrt_04_01()) return 0;

//            return UcretAyarlari.ucrt_04_02() + UcretAyarlari.ucrt_04_02() * (decimal)0.10 * (parselSayisi - UcretAyarlari.ucrt_04_01());
//        }

//        public decimal birlestirmeIsTuruDegeriyle(decimal hamDeger, int isTuru, decimal ik)
//        {
//            if (isTuru == IsTuruMaddeleri.ImarPlani()) return hamDeger * ik * UcretAyarlari.ucrt_04_03(); // Is Turu - Imar P
//            if (isTuru == IsTuruMaddeleri.MucahirIci()) return hamDeger * ik * UcretAyarlari.ucrt_04_04(); // Is Turu - Much, ici
//            if (isTuru == IsTuruMaddeleri.MucahirDisi()) return hamDeger * ik * UcretAyarlari.ucrt_04_05(); // Is turu - Much disi
//            return 0;
//        }

//        public decimal birlestirmeHesapla(int parselSayisi, int isTuru, decimal ik)
//        {
//            return birlestirmeIsTuruDegeriyle(birlestirmeHamDeger(parselSayisi), isTuru, ik) < UcretAyarlari.ucrt_04_06() ? UcretAyarlari.ucrt_04_06() : birlestirmeIsTuruDegeriyle(birlestirmeHamDeger(parselSayisi), isTuru, ik);
//        }

//        // CINS DEGISIKLIGI / AYNI YAPI UZERINDE KAT ILAVESI
//        public decimal cinsdegisikligiayniyapiuzerindekatilavesiHamDeger()
//        {
//            return UcretAyarlari.ucrt_05_01();
//        }

//        public decimal cinsdegisikligiayniyapiuzerindekatilavesiHesapla()
//        {
//            return cinsdegisikligiayniyapiuzerindekatilavesiHamDeger();
//        }

//        // CINS DEGISIKLIGI / BINA YAPIMI VE YIKIMI ILE ILGILI OLMAYAN VASIF DONUSTURULMESI
//        public decimal cinsdegisikligibinayapimiveyikimiileilgiliolmayanvasifdonusturulmesiHamDeger(bool araziyeGidilecekmi)
//        {
//            if (araziyeGidilecekmi == true) return UcretAyarlari.ucrt_06_01() + UcretAyarlari.ucrt_06_02();
//            return UcretAyarlari.ucrt_06_01();
//        }

//        public decimal cinsdegisikligibinayapimiveyikimiileilgiliolmayanvasifdonusturulmesiHesapla(bool araziyeGidilecekmi)
//        {
//            return cinsdegisikligibinayapimiveyikimiileilgiliolmayanvasifdonusturulmesiHamDeger(araziyeGidilecekmi);
//        }

//        // CINS DEGISIKLIGI / YAPILI IKEN YAPISIZ HALE GELME (2010/4 SAYILI GENELGE)
//        public decimal cinsdegisikligiyapiliikenyapisizhalegelme20104sayiligenelgeHamDeger()
//        {
//            return UcretAyarlari.ucrt_07_01();
//        }

//        public decimal cinsdegisikligiyapiliikenyapisizhalegelme20104sayiligenelgeHesapla()
//        {
//            return cinsdegisikligiyapiliikenyapisizhalegelme20104sayiligenelgeHamDeger();
//        }

//        // CINS DEGISIKLIGI / YAPISIZ IKEN YAPILI HALE GELME
//        public decimal cinsdegisikligiyapisizikenyapilihalegelmeHamDeger(decimal insaatAlani)
//        {
//            if (insaatAlani == 0) return 0;
//            if (insaatAlani <= 500) return UcretAyarlari.ucrt_08_01();
//            if (insaatAlani > 500) return (insaatAlani - 500) * UcretAyarlari.ucrt_08_02() / 100 + UcretAyarlari.ucrt_08_01();
//            return 0;
//        }

//        public decimal cinsdegisikligiyapisizikenyapilihalegelmeIsTuruDegeriyle(decimal hamDeger, decimal ik, int isTuru, int binaSayisi)
//        {
//            if (binaSayisi == 0) return 0;
//            if (isTuru == IsTuruMaddeleri.ImarPlani()) return hamDeger * ik * UcretAyarlari.ucrt_08_03() + (binaSayisi - 1) * UcretAyarlari.ucrt_08_06(); // Is Turu - Imar P
//            if (isTuru == IsTuruMaddeleri.MucahirIci()) return hamDeger * ik * UcretAyarlari.ucrt_08_04() + (binaSayisi - 1) * UcretAyarlari.ucrt_08_06(); // Is Turu - Much, ici
//            if (isTuru == IsTuruMaddeleri.MucahirDisi()) return hamDeger * ik * UcretAyarlari.ucrt_08_05() + (binaSayisi - 1) * UcretAyarlari.ucrt_08_06(); ; // Is turu - Much disi
//            return 0;
//        }

//        public decimal cinsdegisikligiyapisizikenyapilihalegelmeHesapla(decimal insaatAlani, int binaSayisi, decimal ik, int isTuru)
//        {
//            return cinsdegisikligiyapisizikenyapilihalegelmeIsTuruDegeriyle(cinsdegisikligiyapisizikenyapilihalegelmeHamDeger(insaatAlani), ik, isTuru, binaSayisi) < UcretAyarlari.ucrt_08_07() ? UcretAyarlari.ucrt_08_07() : cinsdegisikligiyapisizikenyapilihalegelmeIsTuruDegeriyle(cinsdegisikligiyapisizikenyapilihalegelmeHamDeger(insaatAlani), ik, isTuru, binaSayisi);
//        }

//        // HATALI BAGIMSIZ DUZELTME ISLEMI
//        public decimal hatalibagimsizduzeltmeislemiHamDeger(int bagimsizBolumSayisi)
//        {
//            if (bagimsizBolumSayisi < UcretAyarlari.ucrt_11_01()) return 0;
//            return UcretAyarlari.ucrt_11_02() + (bagimsizBolumSayisi - UcretAyarlari.ucrt_11_01()) * UcretAyarlari.ucrt_11_03();
//        }

//        public decimal hatalibagimsizduzeltmeislemiHesapla(int bagimsizBolumSayisi)
//        {
//            return hatalibagimsizduzeltmeislemiHamDeger(bagimsizBolumSayisi);
//        }

//        // IRTIFAK HAKKI
//        public decimal irtifakhakkiHamDeger()
//        {
//            return UcretAyarlari.ucrt_12_01();
//        }

//        public decimal irtifakhakkiIsTuruDegeriyle(decimal hamDeger, decimal ik, int isTuru, int parselSayisi)
//        {
//            if (parselSayisi == 0) return 0;
//            if (isTuru == IsTuruMaddeleri.ImarPlani()) return hamDeger * ik * UcretAyarlari.ucrt_12_02() + (parselSayisi - 1) * UcretAyarlari.ucrt_12_05(); // Is Turu - Imar P
//            if (isTuru == IsTuruMaddeleri.MucahirIci()) return hamDeger * ik * UcretAyarlari.ucrt_12_03() + (parselSayisi - 1) * UcretAyarlari.ucrt_12_05(); // Is Turu - Much, ici
//            if (isTuru == IsTuruMaddeleri.MucahirDisi()) return hamDeger * ik * UcretAyarlari.ucrt_12_04() + (parselSayisi - 1) * UcretAyarlari.ucrt_12_05(); ; // Is turu - Much disi
//            return 0;
//        }

//        public decimal irtifakhakkiHesapla(int parselSayisi, decimal ik, int isTuru)
//        {
//            return irtifakhakkiIsTuruDegeriyle(irtifakhakkiHamDeger(), ik, isTuru, parselSayisi);
//        }

//        // KADASTRAL YOL SINIRLARININ BELIRLENMESI
//        public decimal kadastralyolsinirlarininbelirlenmesiHamDeger(int noktaSayisi)
//        {
//            if (noktaSayisi == 0) return 0;
//            if (noktaSayisi <= 10) return UcretAyarlari.ucrt_13_01();
//            if (noktaSayisi > 10) return UcretAyarlari.ucrt_13_01() + (noktaSayisi - 10) * UcretAyarlari.ucrt_13_02();
//            return 0;
//        }

//        public decimal kadastralyolsinirlarininbelirlenmesiHesapla(int noktaSayisi)
//        {
//            return kadastralyolsinirlarininbelirlenmesiHamDeger(noktaSayisi) < UcretAyarlari.ucrt_13_03() ? UcretAyarlari.ucrt_13_03() : kadastralyolsinirlarininbelirlenmesiHamDeger(noktaSayisi);
//        }

//        // YER GOSTERME / BAGIMSIZ BOLUM
//        public decimal yergostermebagimsizbolumHamDeger(int bagimsizBolumSayisi, bool ayniKisiyeAit)
//        {
//            if (ayniKisiyeAit == true) return UcretAyarlari.ucrt_17_01() + (bagimsizBolumSayisi - 1) * UcretAyarlari.ucrt_17_02();
//            return UcretAyarlari.ucrt_17_03() * bagimsizBolumSayisi;
//        }

//        public decimal yergostermebagimsizbolumHesapla(int bagimsizBolumSayisi, bool ayniKisiyeAit)
//        {
//            return yergostermebagimsizbolumHamDeger(bagimsizBolumSayisi, ayniKisiyeAit);
//        }

//        // YER GOSTERME / PARSEL
//        public decimal yergostermeparselHamDeger(int parselSayisi, bool ayniKisiyeAit)
//        {
//            if (ayniKisiyeAit == true) return UcretAyarlari.ucrt_18_01() + (parselSayisi - 1) * UcretAyarlari.ucrt_18_02();
//            return UcretAyarlari.ucrt_18_03() * parselSayisi;
//        }

//        public decimal yergostermeparselHesapla(int parselSayisi, bool ayniKisiyeAit)
//        {
//            return yergostermeparselHamDeger(parselSayisi, ayniKisiyeAit);
//        }

//        // VAZIYET PLANI, BAGIMSIZ BOLUM PLANI
//        public decimal vaziyetplanibagimsizbolumplanihamDeger(decimal parselAlani, int binaSayisi, int katSayisi, decimal b_Bolum, decimal odaKatsayi, bool yuzdeElliCarpanUygula)
//        {
//            // KDV haric !!

//            decimal _return = 0;
//            // parsel alanindan gelen
//            if (parselAlani >= 0 && parselAlani <= 500) _return = UcretAyarlari.ucrt_15_01();
//            if (parselAlani > 500 && parselAlani <= 1000) _return = UcretAyarlari.ucrt_15_01() + (parselAlani - 500) / 100 * UcretAyarlari.ucrt_15_02();
//            if (parselAlani > 1000 && parselAlani <= 2500) _return = UcretAyarlari.ucrt_15_01() + (1000 - 500) / 100 * UcretAyarlari.ucrt_15_02() + (parselAlani - 1000) / 100 * UcretAyarlari.ucrt_15_03();
//            if (parselAlani > 2500 && parselAlani <= 10000) _return = UcretAyarlari.ucrt_15_01() + (1000 - 500) / 100 * UcretAyarlari.ucrt_15_02() + (2500 - 1000) / 100 * UcretAyarlari.ucrt_15_03() + (parselAlani - 2500) / 100 * UcretAyarlari.ucrt_15_04();
//            if (parselAlani > 10000) _return = UcretAyarlari.ucrt_15_01() + (1000 - 500) / 100 * UcretAyarlari.ucrt_15_02() + (2500 - 1000) / 100 * UcretAyarlari.ucrt_15_03() + (10000 - 2500) / 100 * UcretAyarlari.ucrt_15_04() + (parselAlani - 10000) / 1000 * UcretAyarlari.ucrt_15_05();

//            // bina sayisindan gelen
//            _return += (binaSayisi - 1) * UcretAyarlari.ucrt_15_06();
//            // kat sayisindan gelen
//            _return += katSayisi * UcretAyarlari.ucrt_15_07();
//            // b_bolum den gelen
//            _return += b_Bolum * UcretAyarlari.ucrt_15_08();
//            // oda katsayi
//            _return = _return * odaKatsayi;
//            // yuzde elli carpandan gelen
//            if (yuzdeElliCarpanUygula == true) { _return = _return * (decimal)0.5; };

//            // %18 KDV ekle
//            return (decimal)1.18 * _return;
//        }

//        public decimal vaziyetplanibagimsizbolumplaniHesapla(decimal parselAlani, int binaSayisi, int katSayisi, decimal b_Bolum, decimal odaKatsayi, bool yuzdeElliCarpanUygula)
//        {
//            return vaziyetplanibagimsizbolumplanihamDeger(parselAlani, binaSayisi, katSayisi, b_Bolum, odaKatsayi, yuzdeElliCarpanUygula);
//        }

//        // ROPERLI KROKI
//        public decimal roperlikrokiHamDeger(int isTuru, decimal ik, decimal parselAlani, int binaSayisi, bool odaBirimFiyatlariniKullan, decimal odaKatsayi, bool yuzdeElliCarpanUygula)
//        {

//            if (isTuru == 0) return 0;

//            decimal _return = 0;
//            if (!odaBirimFiyatlariniKullan == true)
//            {
//                //Tur 1
//                //KDV Dahil

//                _return = applikasyonHamDeger(parselAlani);

//                // Is turuyle beraber
//                _return = applikasyonIsTuruDegeriyle(_return, isTuru, ik);

//                // Bina sayisi etkisiyle beraber
//                _return += binaSayisi * UcretAyarlari.ucrt_14_02();

//                if (_return < UcretAyarlari.ucrt_14_01()) { _return = UcretAyarlari.ucrt_14_01(); };

//                return _return;
//            };

//            if (odaBirimFiyatlariniKullan == true)
//            {
//                //Tur 2
//                //KDV Haric !!
//                if (parselAlani > 0 && parselAlani <= 500) _return = UcretAyarlari.ucrt_14_03();
//                if (parselAlani > 500 && parselAlani <= 1000) _return += UcretAyarlari.ucrt_14_03() + (parselAlani - 500) / 100 * UcretAyarlari.ucrt_14_04();
//                if (parselAlani > 1000 && parselAlani < 2500) _return += UcretAyarlari.ucrt_14_03() + (1000 - 500) / 100 * UcretAyarlari.ucrt_14_04() + (parselAlani - 1000) / 100 * UcretAyarlari.ucrt_14_05();
//                if (parselAlani > 2500) _return += UcretAyarlari.ucrt_14_03() + (1000 - 500) / 100 * UcretAyarlari.ucrt_14_04() + (2500 - 1000) / 100 * UcretAyarlari.ucrt_14_05() + (parselAlani - 2500) / 100 * UcretAyarlari.ucrt_14_06();
//                // Bina sayisi etkisiyle beraber
//                _return += (binaSayisi - 1) * UcretAyarlari.ucrt_14_07();
//                // Oda katsayisi ile beraber
//                _return *= odaKatsayi;
//                // Yuzde elli carpan uygula
//                if (yuzdeElliCarpanUygula == true) _return *= (decimal)0.5;

//                // %18 KDV ekle
//                return (decimal)1.18 * _return;
//            };

//            return 0;

//        }

//        public decimal roperlikrokiHesapla(int isTuru, decimal ik, decimal parselAlani, int binaSayisi, bool odaBirimFiyatlariniKullan, decimal odaKatsayi, bool yuzdeElliCarpanUygula)
//        {
//            return roperlikrokiHamDeger(isTuru, ik, parselAlani, binaSayisi, odaBirimFiyatlariniKullan, odaKatsayi, yuzdeElliCarpanUygula);
//        }

//        // YAPI APPLIKASYON PROJESI
//        public decimal yapiapplikasyonprojesiHamDeger(decimal binaTabanAlani, int binaSayisi, decimal odaKatsayi, bool yuzde50CarpanUygula)
//        {
//            // KDV Haric !!
//            decimal _return = 0;
//            if (binaTabanAlani > 0 && binaTabanAlani <= 100) _return = UcretAyarlari.ucrt_16_01();
//            if (binaTabanAlani > 100 && binaTabanAlani <= 150) _return = UcretAyarlari.ucrt_16_02();
//            if (binaTabanAlani > 150 && binaTabanAlani <= 250) _return = UcretAyarlari.ucrt_16_03();
//            if (binaTabanAlani > 250 && binaTabanAlani <= 1000) _return += UcretAyarlari.ucrt_16_03() + (binaTabanAlani - 250) / 100 * UcretAyarlari.ucrt_16_04();
//            if (binaTabanAlani > 1000 && binaTabanAlani <= 2000) _return += UcretAyarlari.ucrt_16_03() + (1000 - 250) / 100 * UcretAyarlari.ucrt_16_04() + (binaTabanAlani - 1000) / 100 * UcretAyarlari.ucrt_16_05();
//            if (binaTabanAlani > 2000 && binaTabanAlani <= 5000) _return += UcretAyarlari.ucrt_16_03() + (1000 - 250) / 100 * UcretAyarlari.ucrt_16_04() + (2000 - 1000) / 100 * UcretAyarlari.ucrt_16_05() + (binaTabanAlani - 2000) / 100 * UcretAyarlari.ucrt_16_06();
//            if (binaTabanAlani > 5000) _return += UcretAyarlari.ucrt_16_03() + (1000 - 250) / 100 * UcretAyarlari.ucrt_16_04() + (2000 - 1000) / 100 * UcretAyarlari.ucrt_16_05() + (5000 - 2000) / 100 * UcretAyarlari.ucrt_16_06() + (Math.Truncate((binaTabanAlani - 5000) / 100) + 1) * UcretAyarlari.ucrt_16_07();

//            // Bina sayisindan gelenler
//            if (binaSayisi > 1 && binaSayisi <= 10) _return += (binaSayisi - 1) * UcretAyarlari.ucrt_16_08();
//            if (binaSayisi > 10 && binaSayisi <= 20) _return += (10 - 1) * UcretAyarlari.ucrt_16_08() + (binaSayisi - 10) * UcretAyarlari.ucrt_16_09();
//            if (binaSayisi > 20 && binaSayisi <= 30) _return += (10 - 1) * UcretAyarlari.ucrt_16_08() + (20 - 10) * UcretAyarlari.ucrt_16_09() + (binaSayisi - 20) * UcretAyarlari.ucrt_16_10();
//            if (binaSayisi > 30) _return += (10 - 1) * UcretAyarlari.ucrt_16_08() + (20 - 10) * UcretAyarlari.ucrt_16_09() + (30 - 20) * UcretAyarlari.ucrt_16_10() + (binaSayisi - 30) * UcretAyarlari.ucrt_16_11();
//            // Oda katsayisi ile beraber
//            _return *= odaKatsayi;
//            // Yuzde elli carpan uygula
//            if (yuzde50CarpanUygula == true) _return *= (decimal)0.5;

//            // %18 KDV ekle
//            return (decimal)1.18 * _return;

//        }

//        public decimal yapiapplikasyonprojesiHesapla(decimal binaTabanAlani, int binaSayisi, decimal odaKatsayi, bool yuzde50CarpanUygula)
//        {

//            return yapiapplikasyonprojesiHamDeger(binaTabanAlani, binaSayisi, odaKatsayi, yuzde50CarpanUygula);
//        }

//    };
//}

