using LIKHAB.BusinessLogic.Helpers;
using LIKHAB.DataLayer.DBContext;
using LIKHAB.DataLayer.Models;
using System;
using System.Linq;

namespace LIKHAB.BusinessLogic.UcretHesaplama
{

    public class UcretDokumuHesabi
    {
        private LikhabDBContext _db;

        public UcretDokumuHesabi()
        {
            _db = new LikhabDBContext();
        }

        // Once Genel Toplami alir
        public decimal HesapSonucunuAl(HesapModeli hesap)
        {

            //1	APLİKASYON
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.Aplikasyon)
            {
                return Math.Round(ApplikasyonHesapla(hesap.YuzOlcumu, hesap.IsTuru, hesap.Ik), 2, MidpointRounding.AwayFromZero);
            };
            //2	APLİKASYON / ALTI AY İÇİNDE AYNI YERE KROKI TALEBİ
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.AplikasyonAltiAyIçindeAyniYereKrokiTalebi)
            {
                return Math.Round(AplikasyonAltiAyIçindeAyniYereKrokiTalebiHesapla(hesap.AplikasyonKrokisiSayisi), 2, MidpointRounding.AwayFromZero);
            };
            //4	BIRLESTIRME
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.Birlestirme)
            {
                return Math.Round(BirlestirmeHesapla(hesap.ParselSayisi, hesap.IsTuru, hesap.Ik), 2, MidpointRounding.AwayFromZero);
            };
            //5	CINS DEGISIKLIGI / AYNI YAPI UZERINDE KAT ILAVESI
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.CinsDegisikligiAyniYapiUzerindeKatIlavesi)
            {
                return Math.Round(CinsDegisikligiAyniYapiUzerindeKatIlavesiHesapla, 2, MidpointRounding.AwayFromZero);
            };
            //6	CINS DEGISIKLIGI / BINA YAPIMI VE YIKIMI ILE ILGILI OLMAYAN VASIF DONUSTURULMESI
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.CinsdegisikligiBinaYapimiVeYikimiIleIlgiliOlmayanVasifDonusturulmesi)
            {
                return Math.Round(CinsDegisikligiBinaYapimiVeYikimiIleIlgiliOlmayanVasifDonusturulmesiHesapla(hesap.AraziyeGidilecekmi), 2, MidpointRounding.AwayFromZero);
            };
            //7	CINS DEGISIKLIGI / YAPILI IKEN YAPISIZ HALE GELME (2010 / 4 SAYILI GENELGE)
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.CinsDegisikligiYapiliIkenYapisizHaleGelmeSayiliGenelge)
            {
                return Math.Round(CinsDegisikligiYapiliIkenYapisizHaleGelme20104SayiliGenelgeHesapla, 2, MidpointRounding.AwayFromZero);
            };
            //8	CINS DEGISIKLIGI / YAPISIZ IKEN YAPILI HALE GELME
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.CinsDegisikligiYapisizIkenYapiliHaleGelme)
            {
                return Math.Round(CinsDegisikligiYapisizIkenYapiliHaleGelmeHesapla(hesap.InsaatAlani, hesap.BinaSayisi, hesap.Ik, hesap.IsTuru), 2, MidpointRounding.AwayFromZero);
            };
            //11	HATALI BAGIMSIZ DUZELTME ISLEMI
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.HataliBagimsizDuzeltmeIslemi)
            {
                return Math.Round(HataliBagimsizDuzeltmeIslemiHesapla(hesap.BagimsizBolumSayisi), 2, MidpointRounding.AwayFromZero);
            };
            //12	IRTIFAK HAKKI
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.IrtifakHakki)
            {
                return Math.Round(IrtifakHakkiHesapla(hesap.ParselSayisi, hesap.Ik, hesap.IsTuru), 2, MidpointRounding.AwayFromZero);
            };
            //13	KADASTRAL YOL SINIRLARININ BELIRLENMESI
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.KadastralYolSinirlarininBelirlenmesi)
            {
                return Math.Round(KadastralYolSinirlarininBelirlenmesiHesapla(hesap.NoktaSayisi), 2, MidpointRounding.AwayFromZero);
            };
            //14	ROPERLI KROKI
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.Roperlikroki)
            {
                return Math.Round(RoperliKrokiHesapla(hesap.IsTuru, hesap.Ik, hesap.ParselAlani, hesap.BinaSayisi, hesap.OdaBirimFiyatlariniKullan, hesap.OdaKatsayi, hesap.Yuzde50CarpanUygula), 2, MidpointRounding.AwayFromZero);
            };
            //15	VAZIYET PLANI, BAGIMSIZ BOLUM PLANI
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.VaziyetPlaniBagimsizBolumPlani)
            {
                return Math.Round(VaziyetPlaniBagimsizBolumPlaniHesapla(hesap.ParselAlani, hesap.BinaSayisi, hesap.KatSayisi, hesap.B_Bolum, hesap.OdaKatsayi, hesap.Yuzde50CarpanUygula), 2, MidpointRounding.AwayFromZero);
            };
            //16	YAPI APPLIKASYON PROJESI
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.YapiApplikasyonProjesi)
            {
                return Math.Round(YapiApplikasyonProjesiHesapla(hesap.BinaTabanAlani, hesap.BinaSayisi, hesap.OdaKatsayi, hesap.Yuzde50CarpanUygula), 2, MidpointRounding.AwayFromZero);
            };
            //17	YER GOSTERME / BAGIMSIZ BOLUM
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.YerGostermeBagimsizBolum)
            {
                return Math.Round(YerGostermeBagimsizBolumHesapla(hesap.BagimsizBolumSayisi, hesap.AyniKisiyeAit), 2, MidpointRounding.AwayFromZero);
            };
            //18	YER GOSTERME / PARSEL
            if (hesap.IsinCinsi == IsinCinsiMaddeleri.YerGostermeParsel)
            {
                return Math.Round(YerGostermeParselHesapla(hesap.ParselSayisi, hesap.AyniKisiyeAit), 2, MidpointRounding.AwayFromZero);
            };

            return 0;
        }

        // Genel Toplamin yukarda hesaplanmis haliyle icinde bulundugu UcretDokum modeli son hali icin islenir, STOPAJ ve TEVKIFAT burada girilmistir ancak son seklini bu blokta alir
        public UcretDokumu Hesapla(UcretDokumu record)
        {

            // genel Toplam sifir gonderilmisse, tum gridi sifirla ve geri gonder
            if (Convert.ToDecimal(record.GenelToplam) == 0)
            {
                record.YolUcreti = Math.Round(Convert.ToDecimal(0), 2);
                record.DenetimUcreti = Math.Round(Convert.ToDecimal(0), 2);
                record.DamgaVergisi = Math.Round(Convert.ToDecimal(0), 2);
                record.BelgeUcreti = Math.Round(Convert.ToDecimal(0), 2);
                record.KontrolUcreti = Math.Round(Convert.ToDecimal(0), 2);
                record.Toplam = Math.Round(Convert.ToDecimal(0), 2);
                record.ToplamBrutUcret = Math.Round(Convert.ToDecimal(0), 2);
                record.Stopaj20Percent = Math.Round(Convert.ToDecimal(0), 2);
                record.KesintilerToplami = Math.Round(Convert.ToDecimal(0), 2);
                record.GenelToplam = Math.Round(Convert.ToDecimal(0), 2);
                record.Kdv18Percent = Math.Round(Convert.ToDecimal(0), 2);
                record.TevkifEdilenKdv = Math.Round(Convert.ToDecimal(0), 2);
                record.TahsilEdilenKdv = Math.Round(Convert.ToDecimal(0), 2);
                record.NetAlinan = Math.Round(Convert.ToDecimal(0), 2);
                record.AlinacakGenelToplam = Math.Round(Convert.ToDecimal(0), 2);
                return record;
            };

            decimal genelToplam_ilkdeger = 0; // Belge Ucreti ve Kontrol Ucreti icin gereklidir

            // 1) FATURA KALEMLERI

            // genel toplami yuvarla
            record.GenelToplam = Math.Round(Convert.ToDecimal(record.GenelToplam), 2, MidpointRounding.AwayFromZero);
            genelToplam_ilkdeger = Math.Round(Convert.ToDecimal(record.GenelToplam), 2, MidpointRounding.AwayFromZero);

            // kdv'yi hesaplat
            record.Kdv18Percent = Math.Round(Convert.ToDecimal(record.GenelToplam) - Convert.ToDecimal(record.GenelToplam) / Convert.ToDecimal(1.18), 2, MidpointRounding.AwayFromZero);

            // toplam brut ucreti hesaplat
            record.ToplamBrutUcret = Math.Round(Convert.ToDecimal(record.GenelToplam) / Convert.ToDecimal(1.18), 2, MidpointRounding.AwayFromZero);

            // stopaji hesaplat, stopaj secili ise javascriptten 1 geliyor
            if (Convert.ToDecimal(record.Stopaj20Percent) > 0) { record.Stopaj20Percent = Math.Round(Convert.ToDecimal(record.ToplamBrutUcret) * Convert.ToDecimal(0.20), 2, MidpointRounding.AwayFromZero); }
            else
            {
                record.Stopaj20Percent = Math.Round(Convert.ToDecimal(0), 2, MidpointRounding.AwayFromZero);
            };

            // kesintiler toplamini hesapla
            record.KesintilerToplami = Math.Round(Convert.ToDecimal(record.Stopaj20Percent), 2, MidpointRounding.AwayFromZero);

            var tevkifatOrani = _db.UcretAyarlaris.Where(c => c.UcretKodu == UcretKodu.ucrt_20_04.ToString()).ToList()[0].Parametre;

            // tevkifat varsa
            if (Convert.ToDecimal(record.TevkifEdilenKdv) > 0)
            {
                record.TevkifEdilenKdv = Math.Round(Convert.ToDecimal(record.Kdv18Percent) * Convert.ToDecimal(tevkifatOrani) / 10, 2, MidpointRounding.AwayFromZero);
                record.TahsilEdilenKdv = Math.Round(Convert.ToDecimal(record.Kdv18Percent) * Convert.ToDecimal(10 - tevkifatOrani) / 10, 2, MidpointRounding.AwayFromZero);

                // genel toplam degisir
                record.GenelToplam -= record.TevkifEdilenKdv;

                // stopaj etkeni
                if (Convert.ToDecimal(record.Stopaj20Percent) > 0)
                {
                    // net alinani hesaplat
                    record.NetAlinan = Math.Round(Convert.ToDecimal(record.ToplamBrutUcret) + Convert.ToDecimal(record.TahsilEdilenKdv) - Convert.ToDecimal(record.Stopaj20Percent), 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    // net alinani hesaplat
                    record.NetAlinan = Math.Round(Convert.ToDecimal(record.GenelToplam), 2, MidpointRounding.AwayFromZero);
                };
            }
            else
            {
                record.TevkifEdilenKdv = 0;
                record.TahsilEdilenKdv = 0;

                // genel toplam degismez

                // stopaj etkeni
                if (Convert.ToDecimal(record.Stopaj20Percent) > 0)
                {
                    // net alinani hesaplat
                    record.NetAlinan = Math.Round(Convert.ToDecimal(record.GenelToplam) - Convert.ToDecimal(record.TevkifEdilenKdv) - Convert.ToDecimal(record.Stopaj20Percent), 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    // net alinani hesaplat
                    record.NetAlinan = Math.Round(Convert.ToDecimal(record.GenelToplam), 2, MidpointRounding.AwayFromZero);
                };

            };

            // 2) TAHSİLAT KALEMLERİ:

            // Yol Ucreti
            record.YolUcreti = Math.Round(Convert.ToDecimal(record.YolUcreti), 2, MidpointRounding.AwayFromZero); // burada olmazsa empty stringler sifira donmuyor

            // Damga vergisi
            decimal damgaVergisiUcretKatsayisi = _db.UcretAyarlaris.Where(c => c.UcretKodu == UcretKodu.ucrt_20_03.ToString()).ToList()[0].Parametre;
            decimal damgaVergisiEkUcreti = _db.UcretAyarlaris.Where(c => c.UcretKodu == UcretKodu.ucrt_20_02.ToString()).ToList()[0].Parametre;

            if (Convert.ToDecimal(record.DamgaVergisi) == 0)
            {
                //Toplam Brut Ucret * 0.00948 (Binde 9.48, ayarlardan gelecek)
                record.DamgaVergisi = Math.Round(damgaVergisiUcretKatsayisi * Convert.ToDecimal(record.ToplamBrutUcret), 2, MidpointRounding.AwayFromZero);
            }
            else if (Convert.ToDecimal(record.DamgaVergisi) > 0) // Kadastroya Asli Gibi Verilecek secili, 0.65 TL gelecek (ucret ayarlarindan)
            {
                record.DamgaVergisi = Math.Round(damgaVergisiUcretKatsayisi * Convert.ToDecimal(record.ToplamBrutUcret) + damgaVergisiEkUcreti, 2, MidpointRounding.AwayFromZero);
            };

            // Belge Ucreti ve KontrolUcreti
            decimal belgeUcretikatsayisi = _db.UcretAyarlaris.Where(c => c.UcretKodu == UcretKodu.ucrt_20_05.ToString()).ToList()[0].Parametre,
                    kontrolUcretiKatsayisi = _db.UcretAyarlaris.Where(c => c.UcretKodu == UcretKodu.ucrt_20_06.ToString()).ToList()[0].Parametre;

            if (Convert.ToDecimal(record.BelgeUcreti) > 0) // 1 degeri geliyor demektir
            {
                //Belge Ucreti > BU = GenelToplam * 0.05 (0.05 ayarlardan gelecek, %5)
                record.BelgeUcreti = Math.Round(genelToplam_ilkdeger * belgeUcretikatsayisi, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                record.BelgeUcreti = Math.Round(Convert.ToDecimal(0), 2, MidpointRounding.AwayFromZero);
            };

            if (Convert.ToDecimal(record.KontrolUcreti) > 0) // 1 degeri geliyor demektir
            {
                //Kontrol Ucreti > BU = GenelToplam * 0.05 (0.05 ayarlardan gelecek, %5)
                record.KontrolUcreti = Math.Round(genelToplam_ilkdeger * kontrolUcretiKatsayisi, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                record.KontrolUcreti = Math.Round(Convert.ToDecimal(0), 2, MidpointRounding.AwayFromZero);
            };

            // Denetim ucreti
            var denetimParametresi = _db.UcretAyarlaris.Where(c => c.UcretKodu == UcretKodu.ucrt_20_07.ToString()).ToList()[0];
            record.DenetimUcreti = denetimParametresi.Kullan == true ? Math.Round(denetimParametresi.Parametre, 2, MidpointRounding.AwayFromZero) : Math.Round(Convert.ToDecimal(0), 2, MidpointRounding.AwayFromZero);

            // Tahsilat Kalemleri Toplami
            record.Toplam = Math.Round(
                  Convert.ToDecimal(record.YolUcreti)
                + Convert.ToDecimal(record.DenetimUcreti)
                + Convert.ToDecimal(record.DamgaVergisi)
                + Convert.ToDecimal(record.BelgeUcreti)
                + Convert.ToDecimal(record.KontrolUcreti)
                , 2, MidpointRounding.AwayFromZero);

            // ***********************
            // Genel toplam
            record.AlinacakGenelToplam = Math.Round(Convert.ToDecimal(record.Toplam) + Convert.ToDecimal(record.NetAlinan), 2, MidpointRounding.AwayFromZero);

            // return 
            return record;
        }

        //APLİKASYON 
        public decimal ApplikasyonHamDeger(decimal yuzolcumu)
        {

            if (yuzolcumu > 0 && yuzolcumu <= 1000) return Helpers.UcretAyarlari.Ucrt_01_01;
            if (yuzolcumu > 1000 && yuzolcumu <= 3000) return Helpers.UcretAyarlari.Ucrt_01_02;
            if (yuzolcumu > 3000 && yuzolcumu <= 5000) return Helpers.UcretAyarlari.Ucrt_01_03;
            if (yuzolcumu > 5000 && yuzolcumu <= 10000) return Helpers.UcretAyarlari.Ucrt_01_04;
            if (yuzolcumu > 10000 && yuzolcumu <= 20000) return Helpers.UcretAyarlari.Ucrt_01_05;
            if (yuzolcumu > 20000 && yuzolcumu <= 50000) return Helpers.UcretAyarlari.Ucrt_01_06;
            if (yuzolcumu > 50000 && yuzolcumu <= 100000) return Helpers.UcretAyarlari.Ucrt_01_07;
            if (yuzolcumu > 100000 && yuzolcumu <= 200000) return Helpers.UcretAyarlari.Ucrt_01_08;
            if (yuzolcumu > 200000 && yuzolcumu <= 500000) return Helpers.UcretAyarlari.Ucrt_01_09;
            if (yuzolcumu > 500000) return Helpers.UcretAyarlari.Ucrt_01_09 + (Math.Truncate((yuzolcumu - 500000) / 100000) + 1) * Helpers.UcretAyarlari.Ucrt_01_10;
            return 0;
        }

        public decimal ApplikasyonIsTuruDegeriyle(decimal hamDeger, int isTuru, decimal ik)
        {
            decimal _return = 0;
            if (isTuru == IsTuruMaddeleri.ImarPlani) { _return = hamDeger * ik * Helpers.UcretAyarlari.Ucrt_01_11; return _return; } // Is Turu - Imar P
            if (isTuru == IsTuruMaddeleri.MucahirIci) return hamDeger * ik * Helpers.UcretAyarlari.Ucrt_01_12; // Is Turu - Much, ici
            if (isTuru == IsTuruMaddeleri.MucahirDisi) return hamDeger * ik * Helpers.UcretAyarlari.Ucrt_01_13; // Is turu - Much disi

            return _return;
        }

        public decimal ApplikasyonHesapla(decimal yuzolcumu, int isTuru, decimal ik)
        {
            decimal result = ApplikasyonIsTuruDegeriyle(ApplikasyonHamDeger(yuzolcumu), isTuru, ik);

            if (result > 0 && result < Helpers.UcretAyarlari.Ucrt_01_14)
            {
                return Helpers.UcretAyarlari.Ucrt_01_14;
            }

            return result;

        }

        // APLİKASYON / ALTI AY İÇİNDE AYNI YERE KROKI TALEBİ
        public decimal AplikasyonAltiAyIçindeAyniYereKrokiTalebiHamDeger(int aplikasyonKrokisiSayisi)
        {
            return aplikasyonKrokisiSayisi * Helpers.UcretAyarlari.Ucrt_02_01;
        }

        public decimal AplikasyonAltiAyIçindeAyniYereKrokiTalebiHesapla(int aplikasyonKrokisiSayisi)
        {
            return AplikasyonAltiAyIçindeAyniYereKrokiTalebiHamDeger(aplikasyonKrokisiSayisi);
        }

        // BIRLESTIRME
        public decimal BirlestirmeHamDeger(int parselSayisi)
        {
            if (parselSayisi < Helpers.UcretAyarlari.Ucrt_04_01) return 0;

            return Helpers.UcretAyarlari.Ucrt_04_02 + Helpers.UcretAyarlari.Ucrt_04_02 * (decimal)0.10 * (parselSayisi - Helpers.UcretAyarlari.Ucrt_04_01);
        }

        public decimal BirlestirmeIsTuruDegeriyle(decimal hamDeger, int isTuru, decimal ik)
        {
            if (isTuru == IsTuruMaddeleri.ImarPlani) return hamDeger * ik * Helpers.UcretAyarlari.Ucrt_04_03; // Is Turu - Imar P
            if (isTuru == IsTuruMaddeleri.MucahirIci) return hamDeger * ik * Helpers.UcretAyarlari.Ucrt_04_04; // Is Turu - Much, ici
            if (isTuru == IsTuruMaddeleri.MucahirDisi) return hamDeger * ik * Helpers.UcretAyarlari.Ucrt_04_05; // Is turu - Much disi
            return 0;
        }

        public decimal BirlestirmeHesapla(int parselSayisi, int isTuru, decimal ik)
        {
            return BirlestirmeIsTuruDegeriyle(BirlestirmeHamDeger(parselSayisi), isTuru, ik) < Helpers.UcretAyarlari.Ucrt_04_06 ? Helpers.UcretAyarlari.Ucrt_04_06 : BirlestirmeIsTuruDegeriyle(BirlestirmeHamDeger(parselSayisi), isTuru, ik);
        }

        // CINS DEGISIKLIGI / AYNI YAPI UZERINDE KAT ILAVESI
        public decimal CinsDegisikligiAyniYapiUzerindeKatIlavesiHamDeger => Helpers.UcretAyarlari.Ucrt_05_01;

        public decimal CinsDegisikligiAyniYapiUzerindeKatIlavesiHesapla => CinsDegisikligiAyniYapiUzerindeKatIlavesiHamDeger;

        // CINS DEGISIKLIGI / BINA YAPIMI VE YIKIMI ILE ILGILI OLMAYAN VASIF DONUSTURULMESI
        public decimal CinsDegisikligiBinaYapimiVeYikimiIleIlgiliOlmayanVasifDonusturulmesiHamDeger(bool araziyeGidilecekmi)
        {
            if (araziyeGidilecekmi == true) return Helpers.UcretAyarlari.Ucrt_06_01 + Helpers.UcretAyarlari.Ucrt_06_02;
            return Helpers.UcretAyarlari.Ucrt_06_01;
        }

        public decimal CinsDegisikligiBinaYapimiVeYikimiIleIlgiliOlmayanVasifDonusturulmesiHesapla(bool araziyeGidilecekmi)
        {
            return CinsDegisikligiBinaYapimiVeYikimiIleIlgiliOlmayanVasifDonusturulmesiHamDeger(araziyeGidilecekmi);
        }

        // CINS DEGISIKLIGI / YAPILI IKEN YAPISIZ HALE GELME (2010/4 SAYILI GENELGE)
        public decimal CinsDegisikligiYapiliIkenYapisizHaleGelme20104SayiliGenelgeHamDeger => Helpers.UcretAyarlari.Ucrt_07_01;

        public decimal CinsDegisikligiYapiliIkenYapisizHaleGelme20104SayiliGenelgeHesapla => CinsDegisikligiYapiliIkenYapisizHaleGelme20104SayiliGenelgeHamDeger;

        // CINS DEGISIKLIGI / YAPISIZ IKEN YAPILI HALE GELME
        public decimal CinsDegisikligiYapisizIkenYapiliHaleGelmeHamDeger(decimal insaatAlani)
        {
            if (insaatAlani == 0) return 0;
            if (insaatAlani <= 500) return Helpers.UcretAyarlari.Ucrt_08_01;
            if (insaatAlani > 500) return (insaatAlani - 500) * Helpers.UcretAyarlari.Ucrt_08_02 / 100 + Helpers.UcretAyarlari.Ucrt_08_01;
            return 0;
        }

        public decimal CinsDegisikligiYapisizIkenYapiliHaleGelmeIsTuruDegeriyle(decimal hamDeger, decimal ik, int isTuru, int binaSayisi)
        {
            if (binaSayisi == 0) return 0;
            if (isTuru == IsTuruMaddeleri.ImarPlani) return hamDeger * ik * Helpers.UcretAyarlari.Ucrt_08_03 + (binaSayisi - 1) * Helpers.UcretAyarlari.Ucrt_08_06; // Is Turu - Imar P
            if (isTuru == IsTuruMaddeleri.MucahirIci) return hamDeger * ik * Helpers.UcretAyarlari.Ucrt_08_04 + (binaSayisi - 1) * Helpers.UcretAyarlari.Ucrt_08_06; // Is Turu - Much, ici
            if (isTuru == IsTuruMaddeleri.MucahirDisi) return hamDeger * ik * Helpers.UcretAyarlari.Ucrt_08_05 + (binaSayisi - 1) * Helpers.UcretAyarlari.Ucrt_08_06; ; // Is turu - Much disi
            return 0;
        }

        public decimal CinsDegisikligiYapisizIkenYapiliHaleGelmeHesapla(decimal insaatAlani, int binaSayisi, decimal ik, int isTuru)
        {
            return CinsDegisikligiYapisizIkenYapiliHaleGelmeIsTuruDegeriyle(CinsDegisikligiYapisizIkenYapiliHaleGelmeHamDeger(insaatAlani), ik, isTuru, binaSayisi) < Helpers.UcretAyarlari.Ucrt_08_07 ? Helpers.UcretAyarlari.Ucrt_08_07 : CinsDegisikligiYapisizIkenYapiliHaleGelmeIsTuruDegeriyle(CinsDegisikligiYapisizIkenYapiliHaleGelmeHamDeger(insaatAlani), ik, isTuru, binaSayisi);
        }

        // HATALI BAGIMSIZ DUZELTME ISLEMI
        public decimal HataliBagimsizDuzeltmeIslemiHamDeger(int bagimsizBolumSayisi)
        {
            if (bagimsizBolumSayisi < Helpers.UcretAyarlari.Ucrt_11_01) return 0;
            return Helpers.UcretAyarlari.Ucrt_11_02 + (bagimsizBolumSayisi - Helpers.UcretAyarlari.Ucrt_11_01) * Helpers.UcretAyarlari.Ucrt_11_03;
        }

        public decimal HataliBagimsizDuzeltmeIslemiHesapla(int bagimsizBolumSayisi)
        {
            return HataliBagimsizDuzeltmeIslemiHamDeger(bagimsizBolumSayisi);
        }

        // IRTIFAK HAKKI
        public decimal IrtifakhakkiHamDeger => Helpers.UcretAyarlari.Ucrt_12_01;

        public decimal IrtifakHakkiIsTuruDegeriyle(decimal hamDeger, decimal ik, int isTuru, int parselSayisi)
        {
            if (parselSayisi == 0) return 0;
            if (isTuru == IsTuruMaddeleri.ImarPlani) return hamDeger * ik * Helpers.UcretAyarlari.Ucrt_12_02 + (parselSayisi - 1) * Helpers.UcretAyarlari.Ucrt_12_05; // Is Turu - Imar P
            if (isTuru == IsTuruMaddeleri.MucahirIci) return hamDeger * ik * Helpers.UcretAyarlari.Ucrt_12_03 + (parselSayisi - 1) * Helpers.UcretAyarlari.Ucrt_12_05; // Is Turu - Much, ici
            if (isTuru == IsTuruMaddeleri.MucahirDisi) return hamDeger * ik * Helpers.UcretAyarlari.Ucrt_12_04 + (parselSayisi - 1) * Helpers.UcretAyarlari.Ucrt_12_05; ; // Is turu - Much disi
            return 0;
        }

        public decimal IrtifakHakkiHesapla(int parselSayisi, decimal ik, int isTuru)
        {
            return IrtifakHakkiIsTuruDegeriyle(IrtifakhakkiHamDeger, ik, isTuru, parselSayisi);
        }

        // KADASTRAL YOL SINIRLARININ BELIRLENMESI
        public decimal KadastralYolSinirlarininBelirlenmesiHamDeger(int noktaSayisi)
        {
            if (noktaSayisi == 0) return 0;
            if (noktaSayisi <= 10) return Helpers.UcretAyarlari.Ucrt_13_01;
            if (noktaSayisi > 10) return Helpers.UcretAyarlari.Ucrt_13_01 + (noktaSayisi - 10) * Helpers.UcretAyarlari.Ucrt_13_02;
            return 0;
        }

        public decimal KadastralYolSinirlarininBelirlenmesiHesapla(int noktaSayisi)
        {
            return KadastralYolSinirlarininBelirlenmesiHamDeger(noktaSayisi) < Helpers.UcretAyarlari.Ucrt_13_03 ? Helpers.UcretAyarlari.Ucrt_13_03 : KadastralYolSinirlarininBelirlenmesiHamDeger(noktaSayisi);
        }

        // YER GOSTERME / BAGIMSIZ BOLUM
        public decimal YerGostermeBagimsizBolumHamDeger(int bagimsizBolumSayisi, bool ayniKisiyeAit)
        {
            if (ayniKisiyeAit == true) return Helpers.UcretAyarlari.Ucrt_17_01 + (bagimsizBolumSayisi - 1) * Helpers.UcretAyarlari.Ucrt_17_02;
            return Helpers.UcretAyarlari.Ucrt_17_03 * bagimsizBolumSayisi;
        }

        public decimal YerGostermeBagimsizBolumHesapla(int bagimsizBolumSayisi, bool ayniKisiyeAit)
        {
            return YerGostermeBagimsizBolumHamDeger(bagimsizBolumSayisi, ayniKisiyeAit);
        }

        // YER GOSTERME / PARSEL
        public decimal YerGostermeParselHamDeger(int parselSayisi, bool ayniKisiyeAit)
        {
            if (ayniKisiyeAit == true) return Helpers.UcretAyarlari.Ucrt_18_01 + (parselSayisi - 1) * Helpers.UcretAyarlari.Ucrt_18_02;
            return Helpers.UcretAyarlari.Ucrt_18_03 * parselSayisi;
        }

        public decimal YerGostermeParselHesapla(int parselSayisi, bool ayniKisiyeAit)
        {
            return YerGostermeParselHamDeger(parselSayisi, ayniKisiyeAit);
        }

        // VAZIYET PLANI, BAGIMSIZ BOLUM PLANI
        public decimal VaziyetPlaniBagimsizBolumPlaniHamDeger(decimal parselAlani, int binaSayisi, int katSayisi, decimal b_Bolum, decimal odaKatsayi, bool yuzdeElliCarpanUygula)
        {
            // KDV haric !!

            decimal _return = 0;
            // parsel alanindan gelen
            if (parselAlani >= 0 && parselAlani <= 500) _return = Helpers.UcretAyarlari.Ucrt_15_01;
            if (parselAlani > 500 && parselAlani <= 1000) _return = Helpers.UcretAyarlari.Ucrt_15_01 + (parselAlani - 500) / 100 * Helpers.UcretAyarlari.Ucrt_15_02;
            if (parselAlani > 1000 && parselAlani <= 2500) _return = Helpers.UcretAyarlari.Ucrt_15_01 + (1000 - 500) / 100 * Helpers.UcretAyarlari.Ucrt_15_02 + (parselAlani - 1000) / 100 * Helpers.UcretAyarlari.Ucrt_15_03;
            if (parselAlani > 2500 && parselAlani <= 10000) _return = Helpers.UcretAyarlari.Ucrt_15_01 + (1000 - 500) / 100 * Helpers.UcretAyarlari.Ucrt_15_02 + (2500 - 1000) / 100 * Helpers.UcretAyarlari.Ucrt_15_03 + (parselAlani - 2500) / 100 * Helpers.UcretAyarlari.Ucrt_15_04;
            if (parselAlani > 10000) _return = Helpers.UcretAyarlari.Ucrt_15_01 + (1000 - 500) / 100 * Helpers.UcretAyarlari.Ucrt_15_02 + (2500 - 1000) / 100 * Helpers.UcretAyarlari.Ucrt_15_03 + (10000 - 2500) / 100 * Helpers.UcretAyarlari.Ucrt_15_04 + (parselAlani - 10000) / 1000 * Helpers.UcretAyarlari.Ucrt_15_05;

            // bina sayisindan gelen
            _return += (binaSayisi - 1) * Helpers.UcretAyarlari.Ucrt_15_06;
            // kat sayisindan gelen
            _return += katSayisi * Helpers.UcretAyarlari.Ucrt_15_07;
            // b_bolum den gelen
            _return += b_Bolum * Helpers.UcretAyarlari.Ucrt_15_08;
            // oda katsayi
            _return = _return * odaKatsayi;
            // yuzde elli carpandan gelen
            if (yuzdeElliCarpanUygula == true) { _return = _return * (decimal)0.5; };

            // %18 KDV ekle
            return (decimal)1.18 * _return;
        }

        public decimal VaziyetPlaniBagimsizBolumPlaniHesapla(decimal parselAlani, int binaSayisi, int katSayisi, decimal b_Bolum, decimal odaKatsayi, bool yuzdeElliCarpanUygula)
        {
            return VaziyetPlaniBagimsizBolumPlaniHamDeger(parselAlani, binaSayisi, katSayisi, b_Bolum, odaKatsayi, yuzdeElliCarpanUygula);
        }

        // ROPERLI KROKI
        public decimal RoperliKrokiHamDeger(int isTuru, decimal ik, decimal parselAlani, int binaSayisi, bool odaBirimFiyatlariniKullan, decimal odaKatsayi, bool yuzdeElliCarpanUygula)
        {

            if (isTuru == 0) return 0;

            decimal _return = 0;
            if (!odaBirimFiyatlariniKullan == true)
            {
                //Tur 1
                //KDV Dahil

                _return = ApplikasyonHamDeger(parselAlani);

                // Is turuyle beraber
                _return = ApplikasyonIsTuruDegeriyle(_return, isTuru, ik);

                // Bina sayisi etkisiyle beraber
                _return += binaSayisi * Helpers.UcretAyarlari.Ucrt_14_02;

                if (_return < Helpers.UcretAyarlari.Ucrt_14_01) { _return = Helpers.UcretAyarlari.Ucrt_14_01; };

                return _return;
            };

            if (odaBirimFiyatlariniKullan == true)
            {
                //Tur 2
                //KDV Haric !!
                if (parselAlani > 0 && parselAlani <= 500) _return = Helpers.UcretAyarlari.Ucrt_14_03;
                if (parselAlani > 500 && parselAlani <= 1000) _return += Helpers.UcretAyarlari.Ucrt_14_03 + (parselAlani - 500) / 100 * Helpers.UcretAyarlari.Ucrt_14_04;
                if (parselAlani > 1000 && parselAlani < 2500) _return += Helpers.UcretAyarlari.Ucrt_14_03 + (1000 - 500) / 100 * Helpers.UcretAyarlari.Ucrt_14_04 + (parselAlani - 1000) / 100 * Helpers.UcretAyarlari.Ucrt_14_05;
                if (parselAlani > 2500) _return += Helpers.UcretAyarlari.Ucrt_14_03 + (1000 - 500) / 100 * Helpers.UcretAyarlari.Ucrt_14_04 + (2500 - 1000) / 100 * Helpers.UcretAyarlari.Ucrt_14_05 + (parselAlani - 2500) / 100 * Helpers.UcretAyarlari.Ucrt_14_06;
                // Bina sayisi etkisiyle beraber
                _return += (binaSayisi - 1) * Helpers.UcretAyarlari.Ucrt_14_07;
                // Oda katsayisi ile beraber
                _return *= odaKatsayi;
                // Yuzde elli carpan uygula
                if (yuzdeElliCarpanUygula == true) _return *= (decimal)0.5;

                // %18 KDV ekle
                return (decimal)1.18 * _return;
            };

            return 0;

        }

        public decimal RoperliKrokiHesapla(int isTuru, decimal ik, decimal parselAlani, int binaSayisi, bool odaBirimFiyatlariniKullan, decimal odaKatsayi, bool yuzdeElliCarpanUygula)
        {
            return RoperliKrokiHamDeger(isTuru, ik, parselAlani, binaSayisi, odaBirimFiyatlariniKullan, odaKatsayi, yuzdeElliCarpanUygula);
        }

        // YAPI APPLIKASYON PROJESI
        public decimal YapiApplikasyonProjesiHamDeger(decimal binaTabanAlani, int binaSayisi, decimal odaKatsayi, bool yuzde50CarpanUygula)
        {
            // KDV Haric !!
            decimal _return = 0;
            if (binaTabanAlani > 0 && binaTabanAlani <= 100) _return = Helpers.UcretAyarlari.Ucrt_16_01;
            if (binaTabanAlani > 100 && binaTabanAlani <= 150) _return = Helpers.UcretAyarlari.Ucrt_16_02;
            if (binaTabanAlani > 150 && binaTabanAlani <= 250) _return = Helpers.UcretAyarlari.Ucrt_16_03;
            if (binaTabanAlani > 250 && binaTabanAlani <= 1000) _return += Helpers.UcretAyarlari.Ucrt_16_03 + (binaTabanAlani - 250) / 100 * Helpers.UcretAyarlari.Ucrt_16_04;
            if (binaTabanAlani > 1000 && binaTabanAlani <= 2000) _return += Helpers.UcretAyarlari.Ucrt_16_03 + (1000 - 250) / 100 * Helpers.UcretAyarlari.Ucrt_16_04 + (binaTabanAlani - 1000) / 100 * Helpers.UcretAyarlari.Ucrt_16_05;
            if (binaTabanAlani > 2000 && binaTabanAlani <= 5000) _return += Helpers.UcretAyarlari.Ucrt_16_03 + (1000 - 250) / 100 * Helpers.UcretAyarlari.Ucrt_16_04 + (2000 - 1000) / 100 * Helpers.UcretAyarlari.Ucrt_16_05 + (binaTabanAlani - 2000) / 100 * Helpers.UcretAyarlari.Ucrt_16_06;
            if (binaTabanAlani > 5000) _return += Helpers.UcretAyarlari.Ucrt_16_03 + (1000 - 250) / 100 * Helpers.UcretAyarlari.Ucrt_16_04 + (2000 - 1000) / 100 * Helpers.UcretAyarlari.Ucrt_16_05 + (5000 - 2000) / 100 * Helpers.UcretAyarlari.Ucrt_16_06 + (Math.Truncate((binaTabanAlani - 5000) / 100) + 1) * Helpers.UcretAyarlari.Ucrt_16_07;

            // Bina sayisindan gelenler
            if (binaSayisi > 1 && binaSayisi <= 10) _return += (binaSayisi - 1) * Helpers.UcretAyarlari.Ucrt_16_08;
            if (binaSayisi > 10 && binaSayisi <= 20) _return += (10 - 1) * Helpers.UcretAyarlari.Ucrt_16_08 + (binaSayisi - 10) * Helpers.UcretAyarlari.Ucrt_16_09;
            if (binaSayisi > 20 && binaSayisi <= 30) _return += (10 - 1) * Helpers.UcretAyarlari.Ucrt_16_08 + (20 - 10) * Helpers.UcretAyarlari.Ucrt_16_09 + (binaSayisi - 20) * Helpers.UcretAyarlari.Ucrt_16_10;
            if (binaSayisi > 30) _return += (10 - 1) * Helpers.UcretAyarlari.Ucrt_16_08 + (20 - 10) * Helpers.UcretAyarlari.Ucrt_16_09 + (30 - 20) * Helpers.UcretAyarlari.Ucrt_16_10 + (binaSayisi - 30) * Helpers.UcretAyarlari.Ucrt_16_11;
            // Oda katsayisi ile beraber
            _return *= odaKatsayi;
            // Yuzde elli carpan uygula
            if (yuzde50CarpanUygula == true) _return *= (decimal)0.5;

            // %18 KDV ekle
            return (decimal)1.18 * _return;

        }

        public decimal YapiApplikasyonProjesiHesapla(decimal binaTabanAlani, int binaSayisi, decimal odaKatsayi, bool yuzde50CarpanUygula)
        {
            return YapiApplikasyonProjesiHamDeger(binaTabanAlani, binaSayisi, odaKatsayi, yuzde50CarpanUygula);
        }

    };
}