// global degiskenler
var musteriSecilen,
    hesapSonucunuAl,
    modelIsler_Musteri = $("#ModelIsler_Musteri")

// AJAX icin, DocumentReady disinda olmali
function GridViewMusteriSecBtnClick(index) {

    GridViewMusteriSec.GetRowValues(
        index,
        "id",
        function (value) {
            //GridViewMusteriSec.PerformCallback({ id: value });
            VerticalGridMusteriSecilen.PerformCallback({ id: value });
            popupMusteriSec.Hide();
            if (value > 0) { musteriSecilen.show(); };
            modelIsler_Musteri.val(value);
        });
}

$(function () {

// VARIABLES
    {
        // Elementleri burada tanimla
        var isinCinsiElement = $('#inputIsinCinsi'),
            iliElement = $('#inputIli'),
            ilcesiElement = $('#inputIlcesi'),
            koyuMahallesiElement = $('#inputKoyu'),
            ilkatsayisiElement = $('#IlKatsayisi'),
            IK = $.isNumeric(ilkatsayisiElement.text()) ? ilkatsayisiElement.text() : 0,
            modelIsler_IsinCinsi = $("#ModelIsler_IsinCinsi"),
            modelIsler_Koyu_Mahallesi = $("#ModelIsler_Koyu_Mahallesi")

        // Is Cinsi parametreleri
        var YuzOlcumuForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.YuzOlcumu'),
            AplikasyonKrokisiSayisiForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.AplikasyonKrokisiSayisi'),
            ParselSayisiForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.ParselSayisi'),
            NoktaSayisiForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.NoktaSayisi'),
            ParselAlaniForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.ParselAlani'),
            BinaTabanAlaniForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.BinaTabanAlani'),
            InsaatAlaniForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.InsaatAlani'),
            BagimsizBolumSayisiForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.BagimsizBolumSayisi'),
            BinaSayisiForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.BinaSayisi'),
            PlanOrnegiForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.PlanOrnegi'),
            KatSayisiForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.KatSayisi'),
            B_BolumForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.B_Bolum'),
            OdaKatsayiForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.OdaKatsayi'),
            AraziyeGidilecekmiForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.AraziyeGidilecekmi'),
            AyniKisiyeAitForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.AyniKisiyeAit'),
            OdaBirimFiyatlariniKullanForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.OdaBirimFiyatlariniKullan'),
            Yuzde50CarpanUygulaForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.Yuzde50CarpanUygula'),
            IsTuruForm = FormUcretHesapla.GetItemByName('ModelIsler.IsinTuru'),
            YolKilometreForm = FormUcretHesapla.GetItemByName('ModelIsler.YolKilometre'),
            YolUcretiForm = FormUcretHesapla.GetItemByName('ModelIsParametreleri.YolUcreti'),
            KentselDonusumForm = FormUcretHesapla.GetItemByName('ModelIsler.KentselDonusum'),
            updateIK = function (data) { ilkatsayisiElement.text(data); IK = data; },

            // Devexpress instances
            YuzOlcumu = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.YuzOlcumu"),
            AplikasyonKrokisiSayisi = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.AplikasyonKrokisiSayisi"),
            ParselSayisi = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.ParselSayisi"),
            NoktaSayisi = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.NoktaSayisi"),
            ParselAlani = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.ParselAlani"),
            BinaTabanAlani = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.BinaTabanAlani"),
            InsaatAlani = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.InsaatAlani"),
            BagimsizBolumSayisi = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.BagimsizBolumSayisi"),
            BinaSayisi = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.BinaSayisi"),
            PlanOrnegi = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.PlanOrnegi"),
            KatSayisi = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.KatSayisi"),
            B_Bolum = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.B_Bolum"),
            OdaKatsayi = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.OdaKatsayi"),
            AraziyeGidilecekmi = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.AraziyeGidilecekmi"),
            AyniKisiyeAit = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.AyniKisiyeAit"),
            OdaBirimFiyatlariniKullan = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.OdaBirimFiyatlariniKullan"),
            Yuzde50CarpanUygula = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.Yuzde50CarpanUygula"),
            IsTuru = ASPxClientControl.GetControlCollection().GetByName("ModelIsler.IsinTuru"),
            YolKilometre = ASPxClientControl.GetControlCollection().GetByName("ModelIsler.YolKilometre"),
            Stopaj = ASPxClientControl.GetControlCollection().GetByName("ModelIsler.Stopaj"),
            Tevkifatli = ASPxClientControl.GetControlCollection().GetByName("ModelIsler.Tevkifatli"),
            YolUcreti = ASPxClientControl.GetControlCollection().GetByName("ModelIsParametreleri.YolUcreti"),
            YolUcretiniElleGir = ASPxClientControl.GetControlCollection().GetByName("ModelIsler.YolUcretiniElleGir"),
            KadastroyaAsliGibiVerilecek = ASPxClientControl.GetControlCollection().GetByName("ModelIsler.KadastroyaAsliGibiVerilecek"),
            KentselDonusum = ASPxClientControl.GetControlCollection().GetByName("ModelIsler.KentselDonusum"),

            UcretDokumu = ASPxClientControl.GetControlCollection().GetByName("UcretDokumu");
            loadingPanelMusteri = ASPxClientControl.GetControlCollection().GetByName("loadingPanelMusteri");
            lopupMusteriSec = ASPxClientControl.GetControlCollection().GetByName("popupMusteriSec");

        var kontrolUcretiVisible = false;
    }


    // ilk yuklemede yapilacaklar
    musteriSecilen = $("#musteriSecilen").hide();

    // Tevkifat kalemlerini ilk yuklemede gizle

    tevkifatGizleYadaGoster = function () {
        if (Tevkifatli.GetChecked()) {
            $(UcretDokumu.GetHtmlRow(UcretDokumu.GetRowByField('TevkifEdilenKDV').index)).show()
            $(UcretDokumu.GetHtmlRow(UcretDokumu.GetRowByField('TahsilEdilenKDV').index)).show()
        } else {
            $(UcretDokumu.GetHtmlRow(UcretDokumu.GetRowByField('TevkifEdilenKDV').index)).hide()
            $(UcretDokumu.GetHtmlRow(UcretDokumu.GetRowByField('TahsilEdilenKDV').index)).hide()
        }
    };

    kontrolUcretiGizleYadaGoster = function () {
        if (kontrolUcretiVisible) {
            $(UcretDokumu.GetHtmlRow(UcretDokumu.GetRowByField('KontrolUcreti').index)).show();
        } else {
            $(UcretDokumu.GetHtmlRow(UcretDokumu.GetRowByField('KontrolUcreti').index)).hide();
        }
    };

    tevkifatGizleYadaGoster();

    kontrolUcretiGizleYadaGoster();

    ucretDokumuEndCallback = function (s, e) {
        tevkifatGizleYadaGoster();
        kontrolUcretiGizleYadaGoster();
    };

    hideAll = function () {
        YuzOlcumuForm.SetVisible(false); YuzOlcumu.isValid = true; YuzOlcumu.SetValue();
        AplikasyonKrokisiSayisiForm.SetVisible(false); AplikasyonKrokisiSayisi.isValid = true; AplikasyonKrokisiSayisi.SetValue();
        ParselSayisiForm.SetVisible(false); ParselSayisi.isValid = true; ParselSayisi.SetValue();
        NoktaSayisiForm.SetVisible(false); NoktaSayisi.isValid = true; NoktaSayisi.SetValue();
        ParselAlaniForm.SetVisible(false); ParselAlani.isValid = true; ParselAlani.SetValue();
        BinaTabanAlaniForm.SetVisible(false); BinaTabanAlani.isValid = true; BinaTabanAlani.SetValue();
        InsaatAlaniForm.SetVisible(false); InsaatAlani.isValid = true; InsaatAlani.SetValue();
        BagimsizBolumSayisiForm.SetVisible(false); BagimsizBolumSayisi.isValid = true; BagimsizBolumSayisi.SetValue();
        BinaSayisiForm.SetVisible(false); BinaSayisi.isValid = true; BinaSayisi.SetValue();
        PlanOrnegiForm.SetVisible(false); PlanOrnegi.isValid = true; PlanOrnegi.SetValue();
        KatSayisiForm.SetVisible(false); KatSayisi.isValid = true; KatSayisi.SetValue();
        B_BolumForm.SetVisible(false); B_Bolum.isValid = true; B_Bolum.SetValue();
        OdaKatsayiForm.SetVisible(false); OdaKatsayi.isValid = true; OdaKatsayi.SetValue();
        AraziyeGidilecekmiForm.SetVisible(false); AraziyeGidilecekmi.isValid = true; AraziyeGidilecekmi.SetValue();
        AyniKisiyeAitForm.SetVisible(false); AyniKisiyeAit.isValid = true; AyniKisiyeAit.SetValue();
        OdaBirimFiyatlariniKullanForm.SetVisible(false); OdaBirimFiyatlariniKullan.isValid = true; OdaBirimFiyatlariniKullan.SetValue();
        Yuzde50CarpanUygulaForm.SetVisible(false); Yuzde50CarpanUygula.isValid = true; Yuzde50CarpanUygula.SetValue();
        IsTuruForm.SetVisible(false); IsTuru.isValid = true; IsTuru.SetValue();
        KentselDonusumForm.SetVisible(false); KentselDonusum.isValid = true; KentselDonusum.SetValue();
        FormUcretHesapla.GetItemByName('GroupParametreler').SetVisible(false);
    };

    OnYuzolcumuValidation = function (s, e) {
        if (!e.value) {
            e.isValid = false;
            e.errorText = "Yuzolcumu gerekli";
            return;
        };
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };
    };

    OnAplikasyonKrokisiSayisiValidation = function (s, e) {
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };

        if (e.value % 1 != 0) {
            e.isValid = false;
            e.errorText = "Tam sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };

    };

    OnNoktaSayisiValidation = function (s, e) {
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };

        if (e.value % 1 != 0) {
            e.isValid = false;
            e.errorText = "Tam sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };

    };

    OnParselSayisiValidation = function (s, e) {

        var criter = inputIsinCinsi.option('value') == 12 ? 1 : 2;

        if (e.value < criter) {
            e.isValid = false;
            e.errorText = criter + " den kucuk olamaz";
            return;
        };
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };

        if (e.value % 1 != 0) {
            e.isValid = false;
            e.errorText = "Tam sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };

    };

    OnBagimsizBolumSayisiValidation = function (s, e) {
        if (e.value < 2) {
            e.isValid = false;
            e.errorText = "2 den kucuk olamaz";
            return;
        };
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
        };

        if (e.value % 1 != 0) {
            e.isValid = false;
            e.errorText = "Tam sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };

    };

    OnParselAlaniValidation = function (s, e) {
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };
    };

    OnBinaSayisiValidation = function (s, e) {
        //14	ROPERLI KROKI
        //15	VAZIYET PLANI, BAGIMSIZ BOLUM PLANI
        if (inputIsinCinsi.option('value') == 14 || inputIsinCinsi.option('value') == 15) {
            if (e.value <= 0) {
                e.isValid = false;
                e.errorText = "0 olamaz";
                return;
            };
            if (!$.isNumeric(e.value)) {
                e.isValid = false;
                e.errorText = "Sayi olmali";
            };
            if (e.value % 1 != 0) {
                e.isValid = false;
                e.errorText = "Tam sayi olmali";
                return;
            };
            if (e.value < 0) {
                e.isValid = false;
                e.errorText = "Sifirdan kucuk olamaz";
                return;
            };
        }
    };

    OnBinaTabanAlaniValidation = function (s, e) {
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };
    };

    OnInsaatAlaniValidation = function (s, e) {
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };
    };

    OnOdaKatsayiValidation = function (s, e) {
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };
    };

    OnB_BolumValidation = function (s, e) {
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };
    };

    OnKatSayisiValidation = function (s, e) {
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };
        if (e.value % 1 != 0) {
            e.isValid = false;
            e.errorText = "Tam sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };

    };

    OnPlanOrnegiValidation = function (s, e) {
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };
    };

    OnBinaSayisiValidation = function (s, e) {
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };
        if (e.value % 1 != 0) {
            e.isValid = false;
            e.errorText = "Tam sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };

    };

    OnInsaatAlaniValidation = function (s, e) {
        if (!$.isNumeric(e.value)) {
            e.isValid = false;
            e.errorText = "Sayi olmali";
            return;
        };
        if (e.value < 0) {
            e.isValid = false;
            e.errorText = "Sifirdan kucuk olamaz";
            return;
        };
    };

    OnIsTuruValidation = function (s, e) {
        if (!e.value) {
            e.isValid = false;
            e.errorText = "Is Turu secili olmali";
            return;
        };
    };


    PerformValidationBeforeCalculation = function (e) {
        //1	APLİKASYON
        if (e === 1) {
            
            YuzOlcumu.Validate();
            IsTuru.Validate();

        };
        //2	APLİKASYON / ALTI AY İÇİNDE AYNI YERE KROKI TALEBİ
        if (e === 2) {
            
            AplikasyonKrokisiSayisi.Validate();
        };
        //4	BIRLESTIRME
        if (e === 4) {
            
            ParselSayisi.Validate();
            IsTuru.Validate();
            
        };
        //5	CINS DEGISIKLIGI / AYNI YAPI UZERINDE KAT ILAVESI
        if (e === 5) {
            
            // nothing to show
        };
        //6	CINS DEGISIKLIGI / BINA YAPIMI VE YIKIMI ILE ILGILI OLMAYAN VASIF DONUSTURULMESI
        if (e === 6) {
            
        };
        //7	CINS DEGISIKLIGI / YAPILI IKEN YAPISIZ HALE GELME (2010 / 4 SAYILI GENELGE)
        if (e === 7) {
            
        };
        //8	CINS DEGISIKLIGI / YAPISIZ IKEN YAPILI HALE GELME
        if (e === 8) {
            
            InsaatAlani.Validate();
            BinaSayisi.Validate();
            IsTuru.Validate();
        };
        //11	HATALI BAGIMSIZ DUZELTME ISLEMI
        if (e === 11) {
            
            BagimsizBolumSayisi.Validate();

        };
        //12	IRTIFAK HAKKI
        if (e === 12) {
            
            ParselSayisi.Validate();
            IsTuru.Validate();
            
        };
        //13	KADASTRAL YOL SINIRLARININ BELIRLENMESI
        if (e === 13) {
            
            NoktaSayisi.Validate();
            
        };
        //14	ROPERLI KROKI
        if (e === 14) {
            
            ParselAlani.Validate();
            BinaSayisi.Validate();
            if (OdaBirimFiyatlariniKullan.GetValue() === true) { OdaKatsayi.Validate(); } else { OdaKatsayi.isValid = true; };
            IsTuru.Validate();
            
        };
        //15	VAZIYET PLANI, BAGIMSIZ BOLUM PLANI
        if (e === 15) {
            
            ParselAlani.Validate();
            BinaSayisi.Validate();
            KatSayisi.Validate();
            B_Bolum.Validate();
            OdaKatsayi.Validate();
            
        };
        //16	YAPI APPLIKASYON PROJESI
        if (e === 16) {
            
            BinaTabanAlani.Validate();
            BinaSayisi.Validate();
            OdaKatsayi.Validate();
            
        };
        //17	YER GOSTERME / BAGIMSIZ BOLUM
        if (e === 17) {
            
            BagimsizBolumSayisi.Validate();
            
        };
        //18	YER GOSTERME / PARSEL
        if (e === 18) {
            
            ParselSayisi.Validate();
            
        };

    }


    GetAllValidationResult = function () {

        PerformValidationBeforeCalculation(inputIsinCinsi.option('value'));

        var _return =
            YuzOlcumu.isValid &&
            AplikasyonKrokisiSayisi.isValid &&
            ParselSayisi.isValid &&
            NoktaSayisi.isValid &&
            ParselAlani.isValid &&
            BinaTabanAlani.isValid &&
            InsaatAlani.isValid &&
            BagimsizBolumSayisi.isValid &&
            BinaSayisi.isValid &&
            PlanOrnegi.isValid &&
            KatSayisi.isValid &&
            B_Bolum.isValid &&
            OdaKatsayi.isValid &&
            AraziyeGidilecekmi.isValid &&
            AyniKisiyeAit.isValid &&
            OdaBirimFiyatlariniKullan.isValid &&
            Yuzde50CarpanUygula.isValid &&
            IsTuru.isValid &&
            YolKilometre.isValid &&
            Stopaj.isValid &&
            Tevkifatli.isValid &&
            YolUcreti.isValid &&
            YolUcretiniElleGir.isValid &&
            KadastroyaAsliGibiVerilecek.isValid &&
            KentselDonusum.isValid &&
            inputIsinCinsiValidator.validate().isValid &&
            inputIliValidator.validate().isValid &&
            inputIlceValidator.validate().isValid &&
            inputKoyValidator.validate().isValid


        console.log(YuzOlcumu.isValid + ' YuzOlcumu.isValid');
        console.log(AplikasyonKrokisiSayisi.isValid + ' AplikasyonKrokisiSayisi.isValid');
        console.log(ParselSayisi.isValid + ' ParselSayisi.isValid');
        console.log(NoktaSayisi.isValid + ' NoktaSayisi.isValid');
        console.log(ParselAlani.isValid + ' ParselAlani.isValid');
        console.log(BinaTabanAlani.isValid + ' BinaTabanAlani.isValid');
        console.log(InsaatAlani.isValid + ' InsaatAlani.isValid');
        console.log(BagimsizBolumSayisi.isValid + ' BagimsizBolumSayisi.isValid');
        console.log(BinaSayisi.isValid + ' BinaSayisi.isValid');
        console.log(PlanOrnegi.isValid + ' PlanOrnegi.isValid');
        console.log(KatSayisi.isValid + ' KatSayisi.isValid');
        console.log(B_Bolum.isValid + ' B_Bolum.isValid');
        console.log(OdaKatsayi.isValid + ' OdaKatsayi.isValid');
        console.log(AraziyeGidilecekmi.isValid + ' AraziyeGidilecekmi.isValid');
        console.log(AyniKisiyeAit.isValid + ' AyniKisiyeAit.isValid');
        console.log(OdaBirimFiyatlariniKullan.isValid + ' OdaBirimFiyatlariniKullan.isValid');
        console.log(Yuzde50CarpanUygula.isValid + ' Yuzde50CarpanUygula.isValid');
        console.log(IsTuru.isValid + ' IsTuru.isValid');
        console.log(YolKilometre.isValid + ' YolKilometre.isValid');
        console.log(Stopaj.isValid + ' Stopaj.isValid');
        console.log(Tevkifatli.isValid + ' Tevkifatli.isValid');
        console.log(YolUcreti.isValid + ' YolUcreti.isValid');
        console.log(YolUcretiniElleGir.isValid + ' YolUcretiniElleGir.isValid');
        console.log(KadastroyaAsliGibiVerilecek.isValid + ' KadastroyaAsliGibiVerilecek.isValid');
        console.log(KentselDonusum.isValid + ' KentselDonusum.isValid');
        console.log(inputIsinCinsiValidator.validate().isValid + ' inputIsinCinsiValidator.isValid');
        console.log(inputIliValidator.validate().isValid + ' inputIliValidator.isValid');
        console.log(inputIlceValidator.validate().isValid + ' inputIlceValidator.isValid');
        console.log(inputKoyValidator.validate().isValid + ' inputKoyValidator.isValid');


        return _return;
    };
    
    OnOdaBirimFiyatlariniKullanValueChanged = function (s, e) {
        //14	ROPERLI KROKI
        if (inputIsinCinsi.option('value') == 14) {
            if (s.GetChecked()) {
                OdaKatsayiForm.SetVisible(true);
                Yuzde50CarpanUygulaForm.SetVisible(true);
                IsTuruForm.SetVisible(false);
            } else {
                OdaKatsayiForm.SetVisible(false);
                Yuzde50CarpanUygulaForm.SetVisible(false);
                IsTuruForm.SetVisible(true); IsTuru.Validate();
            }
        }
    };

    OnYolUcretiniElleGirCheckChanged = function (s, e) {
        if (s.GetChecked()) {
            YolKilometreForm.SetVisible(false);
            YolUcretiForm.SetVisible(true);
        } else {
            YolKilometreForm.SetVisible(true);
            YolUcretiForm.SetVisible(false);
        };
        hesapSonucunuYazdir();
        return;
    };

    OnMusteriSecClick = function (s, e) {
        loadingPanelMusteri.Show();
        popupMusteriSec.PerformCallback({ stopaj: Stopaj.GetChecked()});
    };

    OnGridViewMusteriSecBeginCallBack = function (s, e) {
        e.customArgs["stopaj"] = Stopaj.GetChecked();
    };

    OnStopajValueChanged = function (s, e) {
        if (modelIsler_Musteri.val()) {
            console.log(modelIsler_Musteri.val());
            $.getJSON('/Islemler/JSON/MusteriTemsilStopaj/' + modelIsler_Musteri.val()).done(function (data) {
                if (data[0]) {
                    if (data[0].StopajdaGoster && s.GetChecked()) {
                        // no problem
                    } else if (!data[0].StopajdaGoster && !s.GetChecked()) {
                        // no problem
                    } else {
                        DevExpress.ui.dialog.confirm(
                            "Stopaj secenegi degisirse musterinin Temsil Durumu uyusmuyor. Devam ederseniz secili musteri silinecektir.",
                            "Musteri Temsil Durumu Uyusmuyor").done(function (e) {
                                if (e) {
                                    // musteri silinir
                                    VerticalGridMusteriSecilen.PerformCallback({ id: 0 });
                                    musteriSecilen.hide();
                                    modelIsler_Musteri.val(undefined);
                                    DevExpress.ui.notify("Musteri kaldirildi");
                                } else { s.SetValue(!s.GetChecked()) };
                        });
                    };
                };
            });
        };
    };

    isinCinsiElement.dxSelectBox({
        dataSource: '/Islemler/JSON/DDLIsinCinsi/',
        searchEnabled: true,
        searchExpr: ['Tanim'],
        valueExpr: 'id',
        displayExpr: 'Tanim',
        onValueChanged: function (e) {
            modelIsler_IsinCinsi.val(e.value);
            inputIliValidator.validate();

            if (!e.value) {
                hideAll();
            };

            //1	APLİKASYON
            if (e.value === 1) {
                hideAll();
                YuzOlcumuForm.SetVisible(true); YuzOlcumu.Validate();
                IsTuruForm.SetVisible(true); IsTuru.Validate();
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = false;
            };
            //2	APLİKASYON / ALTI AY İÇİNDE AYNI YERE KROKI TALEBİ
            if (e.value === 2) {
                hideAll();
                AplikasyonKrokisiSayisiForm.SetVisible(true); AplikasyonKrokisiSayisi.Validate();
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = false;
            };
            //4	BIRLESTIRME
            if (e.value === 4) {
                hideAll();
                ParselSayisiForm.SetVisible(true); ParselSayisi.Validate();
                IsTuruForm.SetVisible(true); IsTuru.Validate();
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = true;
            };
            //5	CINS DEGISIKLIGI / AYNI YAPI UZERINDE KAT ILAVESI
            if (e.value === 5) {
                hideAll();
                // nothing to show
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = true;
            };
            //6	CINS DEGISIKLIGI / BINA YAPIMI VE YIKIMI ILE ILGILI OLMAYAN VASIF DONUSTURULMESI
            if (e.value === 6) {
                hideAll();
                AraziyeGidilecekmiForm.SetVisible(true);
                AyniKisiyeAitForm.SetVisible(true);
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = true;
            };
            //7	CINS DEGISIKLIGI / YAPILI IKEN YAPISIZ HALE GELME (2010 / 4 SAYILI GENELGE)
            if (e.value === 7) {
                hideAll();
                AyniKisiyeAitForm.SetVisible(true);
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = true;
            };
            //8	CINS DEGISIKLIGI / YAPISIZ IKEN YAPILI HALE GELME
            if (e.value === 8) {
                hideAll();
                InsaatAlaniForm.SetVisible(true); InsaatAlani.Validate();
                BinaSayisiForm.SetVisible(true); BinaSayisi.Validate();
                IsTuruForm.SetVisible(true); IsTuru.Validate();
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = true;
            };
            //11	HATALI BAGIMSIZ DUZELTME ISLEMI
            if (e.value === 11) {
                hideAll();
                BagimsizBolumSayisiForm.SetVisible(true); BagimsizBolumSayisi.Validate();
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = false;
            };
            //12	IRTIFAK HAKKI
            if (e.value === 12) {
                hideAll();
                ParselSayisiForm.SetVisible(true); ParselSayisi.Validate();
                IsTuruForm.SetVisible(true); IsTuru.Validate();
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = true;
            };
            //13	KADASTRAL YOL SINIRLARININ BELIRLENMESI
            if (e.value === 13) {
                hideAll();
                NoktaSayisiForm.SetVisible(true); NoktaSayisi.Validate();
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = false;
            };
            //14	ROPERLI KROKI
            if (e.value === 14) {
                hideAll();
                ParselAlaniForm.SetVisible(true); ParselAlani.Validate();
                BinaSayisiForm.SetVisible(true); BinaSayisi.Validate();
                if (OdaBirimFiyatlariniKullan.GetValue() === true) { OdaKatsayiForm.SetVisible(true); OdaKatsayi.Validate(); } else { OdaKatsayiForm.SetVisible(false); OdaKatsayi.isValid = true; };
                OdaBirimFiyatlariniKullanForm.SetVisible(true);
                OdaBirimFiyatlariniKullan.GetValue() === true ? Yuzde50CarpanUygulaForm.SetVisible(true) : Yuzde50CarpanUygulaForm.SetVisible(false);
                IsTuruForm.SetVisible(true); IsTuru.Validate();
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = false;
            };
            //15	VAZIYET PLANI, BAGIMSIZ BOLUM PLANI
            if (e.value === 15) {
                hideAll();
                ParselAlaniForm.SetVisible(true); ParselAlani.Validate();
                BinaSayisiForm.SetVisible(true); BinaSayisi.Validate();
                KatSayisiForm.SetVisible(true); KatSayisi.Validate();
                B_BolumForm.SetVisible(true); B_Bolum.Validate();
                OdaKatsayiForm.SetVisible(true); OdaKatsayi.Validate();
                Yuzde50CarpanUygulaForm.SetVisible(true);
                kontrolUcretiVisible = false;
            };
            //16	YAPI APPLIKASYON PROJESI
            if (e.value === 16) {
                hideAll();
                BinaTabanAlaniForm.SetVisible(true); BinaTabanAlani.Validate();
                BinaSayisiForm.SetVisible(true); BinaSayisi.Validate();
                OdaKatsayiForm.SetVisible(true); OdaKatsayi.Validate();
                Yuzde50CarpanUygulaForm.SetVisible(true);
                kontrolUcretiVisible = false;
            };
            //17	YER GOSTERME / BAGIMSIZ BOLUM
            if (e.value === 17) {
                hideAll();
                BagimsizBolumSayisiForm.SetVisible(true); BagimsizBolumSayisi.Validate();
                AyniKisiyeAitForm.SetVisible(true);
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = false;
            };
            //18	YER GOSTERME / PARSEL
            if (e.value === 18) {
                hideAll();
                ParselSayisiForm.SetVisible(true); ParselSayisi.Validate();
                AyniKisiyeAitForm.SetVisible(true);
                KentselDonusumForm.SetVisible(true);
                kontrolUcretiVisible = false; kontrolUcretiGizleYadaGoster()
            };

            if (e.value) {
                // eger biri seciliyse kesin bir parametre gelecegi varsayildi, yer acildi
                // en sona getirilmesi gerek cunku HideAll yukarilarda hepsini kapatiyor
                FormUcretHesapla.GetItemByName('GroupParametreler').SetVisible(true);
            };

            // bu esasen Vertical Grid update ederse de calisiyor, ancak deger degismemisse update etmiyor. Burada olmali
            kontrolUcretiGizleYadaGoster();

            //hesapSonucunuYazdir(e.value);
            hesapSonucunuYazdir();

        },
        onInitialized: function (e) {
            hideAll();
        }
    }).dxValidator({ name: 'isinCinsi', validationRules: [{ type: 'required', message: 'Isin cinsi secili olmali' }] });
    var inputIsinCinsi = isinCinsiElement.dxSelectBox('instance'), inputIsinCinsiValidator = isinCinsiElement.dxValidator('instance');

    iliElement.dxSelectBox({
        dataSource: '/Islemler/JSON/DDLIli/',
        searchEnabled: true,
        searchExpr: ['Il'],
        valueExpr: 'id',
        displayExpr: 'Il',
        value: 1, // sonradan kaldir
        onValueChanged: function (e) {
            inputIlce.option('dataSource', '/Islemler/JSON/DDLIlcesi/' + (e.value ? e.value : 0) );
            inputIlce.option('value', undefined);

            var jsonresult;
            if (e.value) {
                $.getJSON('/Islemler/JSON/DDLIli/' + e.value).done(function (data) {
                    updateIK(data[0].IlKatsayisi);
                    //hesapSonucunuYazdir(inputIsinCinsi.option('value'));
                    hesapSonucunuYazdir();
                });
            } else {
                updateIK(e.value);
                //hesapSonucunuYazdir(inputIsinCinsi.option('value'));
                hesapSonucunuYazdir();
            };
        },
        onInitialized: function () {
            updateIK(0.95); // sonradan kaldir
        }
    }).dxValidator({ name: 'Il', validationRules: [{ type: 'required', message: 'Il secili olmali' }] });
    var inputIli = iliElement.dxSelectBox('instance'), inputIliValidator = iliElement.dxValidator('instance');

    ilcesiElement.dxSelectBox({
        dataSource: '/Islemler/JSON/DDLIlcesi/' + inputIli.option('value'),
        searchEnabled: true,
        searchExpr: ['Ilce1'],
        valueExpr: 'id',
        displayExpr: 'Ilce1',
        onValueChanged: function (e) {
            hesapSonucunuYazdir();
            inputKoy.option('dataSource', '/Islemler/JSON/DDLKoyu/' + (e.value ? e.value : 0));
            inputKoy.option('value', undefined);
        }
    }).dxValidator({ name: 'Ilce', validationRules: [{ type: 'required', message: 'Ilce secili olmali' }] });
    var inputIlce = ilcesiElement.dxSelectBox('instance'), inputIlceValidator = ilcesiElement.dxValidator('instance');

    koyuMahallesiElement.dxSelectBox({
        dataSource: '/Islemler/JSON/DDLKoyu/' + inputIlce.option('value'),
        searchEnabled: true,
        searchExpr: ['Koy_Mahalle1'],
        valueExpr: 'id',
        displayExpr: 'Koy_Mahalle1',
        onValueChanged: function (e) {
            modelIsler_Koyu_Mahallesi.val(e.value);
            if (e.value) {
                $.getJSON('/Islemler/JSON/DDLKoyuSecilen/' + e.value).done(function (data) {
                    if (data[0]) { YolKilometre.SetValue(data[0].YolKilometre)};
                    //hesapSonucunuYazdir(inputIsinCinsi.option('value'));
                    hesapSonucunuYazdir();
                });
            } else {
                YolKilometre.SetValue(null);
                //hesapSonucunuYazdir(inputIsinCinsi.option('value'));
                hesapSonucunuYazdir();
            };

        },
    }).dxValidator({ name: 'Koy/Mahalle', validationRules: [{ type: 'required', message: 'Koy/Mahalle secili olmali' }] });
    var inputKoy = koyuMahallesiElement.dxSelectBox('instance'), inputKoyValidator = koyuMahallesiElement.dxValidator('instance');


    getInput = function () {
        return {
            isinCinsi: inputIsinCinsi.option('value'),
            isTuru: IsTuru.GetValue(),
            binaSayisi: BinaSayisi.GetValue(),
            odaKatsayi: OdaKatsayi.GetValue(),
            parselSayisi: ParselSayisi.GetValue(),
            yuzde50CarpanUygula: Yuzde50CarpanUygula.GetValue(),
            ayniKisiyeAit: AyniKisiyeAit.GetValue(),
            bagimsizBolumSayisi: BagimsizBolumSayisi.GetValue(),
            parselAlani: ParselAlani.GetValue(),
            aplikasyonKrokisiSayisi: AplikasyonKrokisiSayisi.GetValue(),
            araziyeGidilecekmi: AraziyeGidilecekmi.GetValue(),
            b_Bolum: B_Bolum.GetValue(),
            binaTabanAlani: BinaTabanAlani.GetValue(),
            insaatAlani: InsaatAlani.GetValue(),
            katSayisi: KatSayisi.GetValue(),
            noktaSayisi: NoktaSayisi.GetValue(),
            odaBirimFiyatlariniKullan: OdaBirimFiyatlariniKullan.GetValue(),
            yuzOlcumu: YuzOlcumu.GetValue(),
            ik : IK
        };
    }

        //public int isinCinsi { get; set; }
        //public int isTuru { get; set; }
        //public int binaSayisi { get; set; }
        //public decimal odaKatsayi { get; set; }
        //public int parselSayisi { get; set; }
        //public bool yuzde50CarpanUygula { get; set; }
        //public bool ayniKisiyeAit { get; set; }
        //public int bagimsizBolumSayisi { get; set; }
        //public decimal parselAlani { get; set; }
        //public int aplikasyonKrokisiSayisi { get; set; }
        //public bool araziyeGidilecekmi { get; set; }
        //public decimal b_Bolum { get; set; }
        //public decimal binaTabanAlani { get; set; }
        //public decimal insaatAlani { get; set; }
        //public int katSayisi { get; set; }
        //public int noktaSayisi { get; set; }
        //public bool odaBirimFiyatlariniKullan { get; set; }
        //public decimal yuzOlcumu { get; set; }
        //public decimal ik { get; set; }





    hesapSonucunuYazdir = function () {

        $.ajax({
            url: '/Islemler/JSON/UcretHesapla/',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(getInput()),
            success: function (result) {

                console.log( 'result > ' + JSON.stringify(result));

                // GenelToplam 
                var hesapSonucu = result.sonuc;

                // VERTICAL GRID HESAPLAMALARI
                if (!GetAllValidationResult()) {
                    // genel toplami sifir gonder. Server tum degerleri sifirlayip geri gonderir
                    UcretDokumu.batchEditApi.SetCellValue(0, "GenelToplam", 0);
                    // Update on CallBack
                    UcretDokumu.UpdateEdit();

                    return;
                };

                loadingPanelHesaplama.Show();

                // 1) FATURA KALEMLERI
                // genel toplami getir
                UcretDokumu.batchEditApi.SetCellValue(0, "GenelToplam", hesapSonucu);

                // stopaj ekle
                if (Stopaj.GetChecked()) {
                    UcretDokumu.batchEditApi.SetCellValue(0, "Stopaj20percent", 1); // 0 dan buyuk olmasi yeter, serverdaki class gerekeni yapiyor
                };

                // stopaji sil
                if (!Stopaj.GetChecked()) {
                    UcretDokumu.batchEditApi.SetCellValue(0, "Stopaj20percent", 0);
                };

                // Tevkifatli hesabi
                if (Tevkifatli.GetChecked()) {
                    UcretDokumu.batchEditApi.SetCellValue(0, "TevkifEdilenKDV", 1); // 0 dan buyuk olmasi yeter, serverdaki class gerekeni yapiyor
                    UcretDokumu.batchEditApi.SetCellValue(0, "TahsilEdilenKDV", 1); // 0 dan buyuk olmasi yeter, serverdaki class gerekeni yapiyor
                } else {
                    UcretDokumu.batchEditApi.SetCellValue(0, "TevkifEdilenKDV", 0);
                    UcretDokumu.batchEditApi.SetCellValue(0, "TahsilEdilenKDV", 0);
                };

                tevkifatGizleYadaGoster();

                // 2) TAHSİLAT KALEMLERİ:
                // Yol ucreti
                var yolucreti;

                if (YolUcretiniElleGir.GetChecked()) {
                    yolucreti = YolUcreti.GetValue();
                } else {
                    yolucreti = Math.round(0.15 * YolKilometre.GetValue() * result.yakitFiyati * 100) / 100;
                };

                UcretDokumu.batchEditApi.SetCellValue(0, "YolUcreti", yolucreti);

                // Damga vergisi
                if (KadastroyaAsliGibiVerilecek.GetChecked()) {
                    UcretDokumu.batchEditApi.SetCellValue(0, "DamgaVergisi", 1); // 0 dan buyuk olmasi yeter, serverdaki class gerekeni yapiyor
                } else {
                    UcretDokumu.batchEditApi.SetCellValue(0, "DamgaVergisi", 0);
                };

                // Belge Ucreti ve KontrolUcreti
                if (!KentselDonusum.GetChecked() && KentselDonusum.IsVisible()) {
                    // belge ucreti hesaba katilir
                    UcretDokumu.batchEditApi.SetCellValue(0, "BelgeUcreti", 1); // 0 dan buyuk olmasi yeter, serverdaki class gerekeni yapiyor

                } else {
                    UcretDokumu.batchEditApi.SetCellValue(0, "BelgeUcreti", 0);
                };

                if (kontrolUcretiVisible && !KentselDonusum.GetChecked()) {
                    // kontrol ucreti hesaba katilir
                    UcretDokumu.batchEditApi.SetCellValue(0, "KontrolUcreti", 1); // 0 dan buyuk olmasi yeter, serverdaki class gerekeni yapiyor
                } else {
                    UcretDokumu.batchEditApi.SetCellValue(0, "KontrolUcreti", 0);
                };

                // Update on CallBack
                UcretDokumu.UpdateEdit();

            },
            fail: function () {
                console.log('bisi olmadi');
                loadingPanelHesaplama.Hide();
            },
            complete: function () {
                setTimeout(function() { loadingPanelHesaplama.Hide(); }, 200);
            }
        });
    };

    
})
