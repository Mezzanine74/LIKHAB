//Xtra_RandevuOnayTalebiEmail
using DevExpress.XtraReports.UI;

namespace LIKHAB.Reports
{
    /// <summary>
    /// Summary description for Xtra_RandevuOnayTalebiEmail
    /// </summary>
    public class Xtra_TeknikHizmetSozlesmesi : DevExpress.XtraReports.UI.XtraReport
    {
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.EntityFramework.EFDataSource efDataSource1;
        private XRControlStyle Title;
        private XRControlStyle GroupCaption3;
        private XRControlStyle GroupData3;
        private XRControlStyle PageInfo;
        private XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.Parameters.Parameter ParametreIsId;
        private XRLabel xrLabel35;
        private XRLabel xrLabel34;
        private XRLabel xrLabel33;
        private XRLabel xrLabel31;
        private XRLabel xrLabel32;
        private XRLabel xrLabel30;
        private XRLabel xrLabel29;
        private XRLabel xrLabel28;
        private XRLabel xrLabel27;
        private XRLabel xrLabelToplamYerGosterme;
        private XRLabel xrLabelToplamIrtifakHakki;
        private XRLabel xrLabelToplamBirlestirme;
        private XRLabel xrLabelToplamCinsDegis;
        private XRLabel xrLabelToplamApplk;
        private XRLabel xrLabelCinsDegisikligi1;
        private XRLabel xrLabelCinsDegisikligi2;
        private XRLabel xrLabelYerGosterme1;
        private XRLabel xrLabelYerGosterme2;
        private XRLabel xrLabelIrtifakHakkiTerkiniCarpi;
        private XRLabel xrLabelIrtifakHakkiTesisiCarpi;
        private XRLabel xrLabelBirlestirmeCarpi;
        private XRLabel xrLabelApplikasyonCarpi;
        private XRLabel xrLabel26;
        private XRLabel xrLabel25;
        private XRLabel xrLabel24;
        private XRLabel xrLabel23;
        private XRLabel xrLabel22;
        private XRLabel xrLabel21;
        private XRLabel xrLabel20;
        private XRLabel xrLabel19;
        private XRLabel xrLabel18;
        private XRLabel xrLabel17;
        private XRLabel xrLabel16;
        private XRLabel xrLabel15;
        private XRLabel xrLabel14;
        private XRLabel xrLabel13;
        private XRLabel xrLabel12;
        private XRLabel xrLabel11;
        private XRLabel xrLabel10;
        private XRLabel xrLabel9;
        private XRLabel xrLabel8;
        private XRLabel xrLabel7;
        private XRLabel xrLabel6;
        private XRLabel xrLabel5;
        private XRLabel xrLabel4;
        private XRLabel xrLabel3;
        private XRLabel xrLabel1;
        private XRLabel xrLabel2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Xtra_TeknikHizmetSozlesmesi()
        {
            InitializeComponent();
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.EntityFramework.EFConnectionParameters efConnectionParameters1 = new DevExpress.DataAccess.EntityFramework.EFConnectionParameters();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xtra_TeknikHizmetSozlesmesi));
            this.efDataSource1 = new DevExpress.DataAccess.EntityFramework.EFDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelToplamYerGosterme = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelToplamIrtifakHakki = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelToplamBirlestirme = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelToplamCinsDegis = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelToplamApplk = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelCinsDegisikligi1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelCinsDegisikligi2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelYerGosterme1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelYerGosterme2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelIrtifakHakkiTerkiniCarpi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelIrtifakHakkiTesisiCarpi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelBirlestirmeCarpi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelApplikasyonCarpi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ParametreIsId = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // efDataSource1
            // 
            efConnectionParameters1.ConnectionString = "";
            efConnectionParameters1.ConnectionStringName = "LIHKAB_dbEntities";
            efConnectionParameters1.Source = typeof(LIKHAB.Models.db.LIHKAB_dbEntities);
            this.efDataSource1.ConnectionParameters = efConnectionParameters1;
            this.efDataSource1.Name = "efDataSource1";
            // 
            // Detail
            // 
            this.Detail.Dpi = 96F;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.BackColor = System.Drawing.Color.Transparent;
            this.TopMargin.BorderWidth = 2F;
            this.TopMargin.Dpi = 96F;
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.StylePriority.UseBorderWidth = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Dpi = 96F;
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(1.92F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(794.8965F, 1123.862F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel35,
            this.xrLabel34,
            this.xrLabel33,
            this.xrLabel31,
            this.xrLabel32,
            this.xrLabel30,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabelToplamYerGosterme,
            this.xrLabelToplamIrtifakHakki,
            this.xrLabelToplamBirlestirme,
            this.xrLabelToplamCinsDegis,
            this.xrLabelToplamApplk,
            this.xrLabelCinsDegisikligi1,
            this.xrLabelCinsDegisikligi2,
            this.xrLabelYerGosterme1,
            this.xrLabelYerGosterme2,
            this.xrLabelIrtifakHakkiTerkiniCarpi,
            this.xrLabelIrtifakHakkiTesisiCarpi,
            this.xrLabelBirlestirmeCarpi,
            this.xrLabelApplikasyonCarpi,
            this.xrLabel26,
            this.xrLabel25,
            this.xrLabel24,
            this.xrLabel23,
            this.xrLabel22,
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel1,
            this.xrLabel2,
            this.xrPictureBox1});
            this.BottomMargin.Dpi = 96F;
            this.BottomMargin.HeightF = 1124F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel35
            // 
            this.xrLabel35.CanGrow = false;
            this.xrLabel35.Dpi = 96F;
            this.xrLabel35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansliBuroNo]")});
            this.xrLabel35.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(78.43998F, 994.5709F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(36.99999F, 26.27997F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel35.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel35_BeforePrint);
            // 
            // xrLabel34
            // 
            this.xrLabel34.CanGrow = false;
            this.xrLabel34.Dpi = 96F;
            this.xrLabel34.EditOptions.Enabled = true;
            this.xrLabel34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FenKayitTarihiYIL]")});
            this.xrLabel34.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(582.44F, 1027.131F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(32.76001F, 24.28003F);
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.StylePriority.UseTextAlignment = false;
            this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel33
            // 
            this.xrLabel33.CanGrow = false;
            this.xrLabel33.Dpi = 96F;
            this.xrLabel33.EditOptions.Enabled = true;
            this.xrLabel33.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FenKayitTarihiYIL]")});
            this.xrLabel33.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(172.4399F, 1028.091F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(32.76001F, 24.28003F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel31
            // 
            this.xrLabel31.CanGrow = false;
            this.xrLabel31.Dpi = 96F;
            this.xrLabel31.EditOptions.Enabled = true;
            this.xrLabel31.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FenKayitTarihiGUN]")});
            this.xrLabel31.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(534.09F, 1027.131F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(32.75995F, 24.28003F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel32
            // 
            this.xrLabel32.CanGrow = false;
            this.xrLabel32.Dpi = 96F;
            this.xrLabel32.EditOptions.Enabled = true;
            this.xrLabel32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FenKayitTarihiAY]")});
            this.xrLabel32.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(552.0701F, 1027.131F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(32.75995F, 24.28003F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel30
            // 
            this.xrLabel30.CanGrow = false;
            this.xrLabel30.Dpi = 96F;
            this.xrLabel30.EditOptions.Enabled = true;
            this.xrLabel30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FenKayitTarihiAY]")});
            this.xrLabel30.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(140.76F, 1028.091F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(32.76001F, 24.28003F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel29
            // 
            this.xrLabel29.CanGrow = false;
            this.xrLabel29.Dpi = 96F;
            this.xrLabel29.EditOptions.Enabled = true;
            this.xrLabel29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FenKayitTarihiGUN]")});
            this.xrLabel29.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(121.7799F, 1028.091F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(32.75999F, 24.28003F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel28
            // 
            this.xrLabel28.CanGrow = false;
            this.xrLabel28.Dpi = 96F;
            this.xrLabel28.EditOptions.Enabled = true;
            this.xrLabel28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IsSahibi]")});
            this.xrLabel28.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(456F, 1007.171F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(242.64F, 26F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel28.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel28_BeforePrint);
            // 
            // xrLabel27
            // 
            this.xrLabel27.CanGrow = false;
            this.xrLabel27.Dpi = 96F;
            this.xrLabel27.EditOptions.Enabled = true;
            this.xrLabel27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansSahibi_AdiSoyadi]")});
            this.xrLabel27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel27.ForeColor = System.Drawing.Color.Black;
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(62.06001F, 1009.091F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(203.88F, 23.99994F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseForeColor = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel27.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel27_BeforePrint);
            // 
            // xrLabelToplamYerGosterme
            // 
            this.xrLabelToplamYerGosterme.CanGrow = false;
            this.xrLabelToplamYerGosterme.Dpi = 96F;
            this.xrLabelToplamYerGosterme.EditOptions.Enabled = true;
            this.xrLabelToplamYerGosterme.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Toplam]")});
            this.xrLabelToplamYerGosterme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelToplamYerGosterme.LocationFloat = new DevExpress.Utils.PointFloat(480.48F, 538.0912F);
            this.xrLabelToplamYerGosterme.Name = "xrLabelToplamYerGosterme";
            this.xrLabelToplamYerGosterme.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelToplamYerGosterme.SizeF = new System.Drawing.SizeF(144F, 24F);
            this.xrLabelToplamYerGosterme.StylePriority.UseFont = false;
            this.xrLabelToplamYerGosterme.StylePriority.UseTextAlignment = false;
            this.xrLabelToplamYerGosterme.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabelToplamYerGosterme.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabelToplamYerGosterme_BeforePrint);
            // 
            // xrLabelToplamIrtifakHakki
            // 
            this.xrLabelToplamIrtifakHakki.CanGrow = false;
            this.xrLabelToplamIrtifakHakki.Dpi = 96F;
            this.xrLabelToplamIrtifakHakki.EditOptions.Enabled = true;
            this.xrLabelToplamIrtifakHakki.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Toplam]")});
            this.xrLabelToplamIrtifakHakki.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelToplamIrtifakHakki.LocationFloat = new DevExpress.Utils.PointFloat(480.48F, 512.1713F);
            this.xrLabelToplamIrtifakHakki.Name = "xrLabelToplamIrtifakHakki";
            this.xrLabelToplamIrtifakHakki.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelToplamIrtifakHakki.SizeF = new System.Drawing.SizeF(144F, 24F);
            this.xrLabelToplamIrtifakHakki.StylePriority.UseFont = false;
            this.xrLabelToplamIrtifakHakki.StylePriority.UseTextAlignment = false;
            this.xrLabelToplamIrtifakHakki.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabelToplamIrtifakHakki.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabelToplamIrtifakHakki_BeforePrint);
            // 
            // xrLabelToplamBirlestirme
            // 
            this.xrLabelToplamBirlestirme.CanGrow = false;
            this.xrLabelToplamBirlestirme.Dpi = 96F;
            this.xrLabelToplamBirlestirme.EditOptions.Enabled = true;
            this.xrLabelToplamBirlestirme.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Toplam]")});
            this.xrLabelToplamBirlestirme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelToplamBirlestirme.LocationFloat = new DevExpress.Utils.PointFloat(480.48F, 486.2512F);
            this.xrLabelToplamBirlestirme.Name = "xrLabelToplamBirlestirme";
            this.xrLabelToplamBirlestirme.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelToplamBirlestirme.SizeF = new System.Drawing.SizeF(144F, 24.00003F);
            this.xrLabelToplamBirlestirme.StylePriority.UseFont = false;
            this.xrLabelToplamBirlestirme.StylePriority.UseTextAlignment = false;
            this.xrLabelToplamBirlestirme.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabelToplamBirlestirme.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabelToplamBirlestirme_BeforePrint);
            // 
            // xrLabelToplamCinsDegis
            // 
            this.xrLabelToplamCinsDegis.CanGrow = false;
            this.xrLabelToplamCinsDegis.Dpi = 96F;
            this.xrLabelToplamCinsDegis.EditOptions.Enabled = true;
            this.xrLabelToplamCinsDegis.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Toplam]")});
            this.xrLabelToplamCinsDegis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelToplamCinsDegis.LocationFloat = new DevExpress.Utils.PointFloat(480.48F, 461.8912F);
            this.xrLabelToplamCinsDegis.Name = "xrLabelToplamCinsDegis";
            this.xrLabelToplamCinsDegis.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelToplamCinsDegis.SizeF = new System.Drawing.SizeF(144F, 24F);
            this.xrLabelToplamCinsDegis.StylePriority.UseFont = false;
            this.xrLabelToplamCinsDegis.StylePriority.UseTextAlignment = false;
            this.xrLabelToplamCinsDegis.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabelToplamCinsDegis.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabelToplamCinsDegis_BeforePrint);
            // 
            // xrLabelToplamApplk
            // 
            this.xrLabelToplamApplk.CanGrow = false;
            this.xrLabelToplamApplk.Dpi = 96F;
            this.xrLabelToplamApplk.EditOptions.Enabled = true;
            this.xrLabelToplamApplk.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Toplam]")});
            this.xrLabelToplamApplk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelToplamApplk.LocationFloat = new DevExpress.Utils.PointFloat(480.48F, 435.9711F);
            this.xrLabelToplamApplk.Name = "xrLabelToplamApplk";
            this.xrLabelToplamApplk.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelToplamApplk.SizeF = new System.Drawing.SizeF(144F, 24F);
            this.xrLabelToplamApplk.StylePriority.UseFont = false;
            this.xrLabelToplamApplk.StylePriority.UseTextAlignment = false;
            this.xrLabelToplamApplk.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabelToplamApplk.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabelToplamApplk_BeforePrint);
            // 
            // xrLabelCinsDegisikligi1
            // 
            this.xrLabelCinsDegisikligi1.CanGrow = false;
            this.xrLabelCinsDegisikligi1.Dpi = 96F;
            this.xrLabelCinsDegisikligi1.EditOptions.Enabled = true;
            this.xrLabelCinsDegisikligi1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelCinsDegisikligi1.LocationFloat = new DevExpress.Utils.PointFloat(349.9599F, 337.36F);
            this.xrLabelCinsDegisikligi1.Name = "xrLabelCinsDegisikligi1";
            this.xrLabelCinsDegisikligi1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelCinsDegisikligi1.SizeF = new System.Drawing.SizeF(18.52002F, 17.28F);
            this.xrLabelCinsDegisikligi1.StylePriority.UseFont = false;
            this.xrLabelCinsDegisikligi1.StylePriority.UseTextAlignment = false;
            this.xrLabelCinsDegisikligi1.Text = "X";
            this.xrLabelCinsDegisikligi1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabelCinsDegisikligi2
            // 
            this.xrLabelCinsDegisikligi2.CanGrow = false;
            this.xrLabelCinsDegisikligi2.Dpi = 96F;
            this.xrLabelCinsDegisikligi2.EditOptions.Enabled = true;
            this.xrLabelCinsDegisikligi2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelCinsDegisikligi2.LocationFloat = new DevExpress.Utils.PointFloat(349.9599F, 354.64F);
            this.xrLabelCinsDegisikligi2.Name = "xrLabelCinsDegisikligi2";
            this.xrLabelCinsDegisikligi2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelCinsDegisikligi2.SizeF = new System.Drawing.SizeF(18.52002F, 17.28F);
            this.xrLabelCinsDegisikligi2.StylePriority.UseFont = false;
            this.xrLabelCinsDegisikligi2.StylePriority.UseTextAlignment = false;
            this.xrLabelCinsDegisikligi2.Text = "X";
            this.xrLabelCinsDegisikligi2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabelYerGosterme1
            // 
            this.xrLabelYerGosterme1.CanGrow = false;
            this.xrLabelYerGosterme1.Dpi = 96F;
            this.xrLabelYerGosterme1.EditOptions.Enabled = true;
            this.xrLabelYerGosterme1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelYerGosterme1.LocationFloat = new DevExpress.Utils.PointFloat(349.9599F, 371.92F);
            this.xrLabelYerGosterme1.Name = "xrLabelYerGosterme1";
            this.xrLabelYerGosterme1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelYerGosterme1.SizeF = new System.Drawing.SizeF(18.52002F, 17.28F);
            this.xrLabelYerGosterme1.StylePriority.UseFont = false;
            this.xrLabelYerGosterme1.StylePriority.UseTextAlignment = false;
            this.xrLabelYerGosterme1.Text = "X";
            this.xrLabelYerGosterme1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabelYerGosterme2
            // 
            this.xrLabelYerGosterme2.CanGrow = false;
            this.xrLabelYerGosterme2.Dpi = 96F;
            this.xrLabelYerGosterme2.EditOptions.Enabled = true;
            this.xrLabelYerGosterme2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelYerGosterme2.LocationFloat = new DevExpress.Utils.PointFloat(349.9599F, 389.2F);
            this.xrLabelYerGosterme2.Name = "xrLabelYerGosterme2";
            this.xrLabelYerGosterme2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelYerGosterme2.SizeF = new System.Drawing.SizeF(18.52002F, 17.28F);
            this.xrLabelYerGosterme2.StylePriority.UseFont = false;
            this.xrLabelYerGosterme2.StylePriority.UseTextAlignment = false;
            this.xrLabelYerGosterme2.Text = "X";
            this.xrLabelYerGosterme2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabelIrtifakHakkiTerkiniCarpi
            // 
            this.xrLabelIrtifakHakkiTerkiniCarpi.CanGrow = false;
            this.xrLabelIrtifakHakkiTerkiniCarpi.Dpi = 96F;
            this.xrLabelIrtifakHakkiTerkiniCarpi.EditOptions.Enabled = true;
            this.xrLabelIrtifakHakkiTerkiniCarpi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelIrtifakHakkiTerkiniCarpi.LocationFloat = new DevExpress.Utils.PointFloat(61.03998F, 389.2F);
            this.xrLabelIrtifakHakkiTerkiniCarpi.Name = "xrLabelIrtifakHakkiTerkiniCarpi";
            this.xrLabelIrtifakHakkiTerkiniCarpi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelIrtifakHakkiTerkiniCarpi.SizeF = new System.Drawing.SizeF(18.52002F, 17.28F);
            this.xrLabelIrtifakHakkiTerkiniCarpi.StylePriority.UseFont = false;
            this.xrLabelIrtifakHakkiTerkiniCarpi.StylePriority.UseTextAlignment = false;
            this.xrLabelIrtifakHakkiTerkiniCarpi.Text = "X";
            this.xrLabelIrtifakHakkiTerkiniCarpi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabelIrtifakHakkiTesisiCarpi
            // 
            this.xrLabelIrtifakHakkiTesisiCarpi.CanGrow = false;
            this.xrLabelIrtifakHakkiTesisiCarpi.Dpi = 96F;
            this.xrLabelIrtifakHakkiTesisiCarpi.EditOptions.Enabled = true;
            this.xrLabelIrtifakHakkiTesisiCarpi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelIrtifakHakkiTesisiCarpi.LocationFloat = new DevExpress.Utils.PointFloat(61.03998F, 371.92F);
            this.xrLabelIrtifakHakkiTesisiCarpi.Name = "xrLabelIrtifakHakkiTesisiCarpi";
            this.xrLabelIrtifakHakkiTesisiCarpi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelIrtifakHakkiTesisiCarpi.SizeF = new System.Drawing.SizeF(18.52002F, 17.28F);
            this.xrLabelIrtifakHakkiTesisiCarpi.StylePriority.UseFont = false;
            this.xrLabelIrtifakHakkiTesisiCarpi.StylePriority.UseTextAlignment = false;
            this.xrLabelIrtifakHakkiTesisiCarpi.Text = "X";
            this.xrLabelIrtifakHakkiTesisiCarpi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabelBirlestirmeCarpi
            // 
            this.xrLabelBirlestirmeCarpi.CanGrow = false;
            this.xrLabelBirlestirmeCarpi.Dpi = 96F;
            this.xrLabelBirlestirmeCarpi.EditOptions.Enabled = true;
            this.xrLabelBirlestirmeCarpi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelBirlestirmeCarpi.LocationFloat = new DevExpress.Utils.PointFloat(61.03998F, 354.64F);
            this.xrLabelBirlestirmeCarpi.Name = "xrLabelBirlestirmeCarpi";
            this.xrLabelBirlestirmeCarpi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelBirlestirmeCarpi.SizeF = new System.Drawing.SizeF(18.52002F, 17.28F);
            this.xrLabelBirlestirmeCarpi.StylePriority.UseFont = false;
            this.xrLabelBirlestirmeCarpi.StylePriority.UseTextAlignment = false;
            this.xrLabelBirlestirmeCarpi.Text = "X";
            this.xrLabelBirlestirmeCarpi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabelApplikasyonCarpi
            // 
            this.xrLabelApplikasyonCarpi.CanGrow = false;
            this.xrLabelApplikasyonCarpi.Dpi = 96F;
            this.xrLabelApplikasyonCarpi.EditOptions.Enabled = true;
            this.xrLabelApplikasyonCarpi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabelApplikasyonCarpi.LocationFloat = new DevExpress.Utils.PointFloat(61.03998F, 337.36F);
            this.xrLabelApplikasyonCarpi.Name = "xrLabelApplikasyonCarpi";
            this.xrLabelApplikasyonCarpi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabelApplikasyonCarpi.SizeF = new System.Drawing.SizeF(18.52002F, 17.28F);
            this.xrLabelApplikasyonCarpi.StylePriority.UseFont = false;
            this.xrLabelApplikasyonCarpi.StylePriority.UseTextAlignment = false;
            this.xrLabelApplikasyonCarpi.Text = "X";
            this.xrLabelApplikasyonCarpi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel26
            // 
            this.xrLabel26.CanGrow = false;
            this.xrLabel26.Dpi = 96F;
            this.xrLabel26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansliBuroNo]")});
            this.xrLabel26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(300.52F, 977.36F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(29F, 26.28003F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel26.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel26_BeforePrint);
            // 
            // xrLabel25
            // 
            this.xrLabel25.CanGrow = false;
            this.xrLabel25.Dpi = 96F;
            this.xrLabel25.EditOptions.Enabled = true;
            this.xrLabel25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FenKayitTarihi]")});
            this.xrLabel25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(153.16F, 976.32F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(98.92003F, 26.27997F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel25.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel25_BeforePrint);
            // 
            // xrLabel24
            // 
            this.xrLabel24.CanGrow = false;
            this.xrLabel24.Dpi = 96F;
            this.xrLabel24.EditOptions.Enabled = true;
            this.xrLabel24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansSahibiIli]")});
            this.xrLabel24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(338.24F, 945.5197F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(119.8401F, 26.27997F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel24.WordWrap = false;
            this.xrLabel24.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel24_BeforePrint);
            // 
            // xrLabel23
            // 
            this.xrLabel23.CanGrow = false;
            this.xrLabel23.Dpi = 96F;
            this.xrLabel23.EditOptions.Enabled = true;
            this.xrLabel23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RandevuZamani]")});
            this.xrLabel23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(563.28F, 312.4F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(146.8799F, 24F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel23.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel23_BeforePrint);
            // 
            // xrLabel22
            // 
            this.xrLabel22.CanGrow = false;
            this.xrLabel22.Dpi = 96F;
            this.xrLabel22.EditOptions.Enabled = true;
            this.xrLabel22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IsinCinsiTanim]")});
            this.xrLabel22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(173.2401F, 312.4F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(168.96F, 26F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel22.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel22_BeforePrint);
            // 
            // xrLabel21
            // 
            this.xrLabel21.CanGrow = false;
            this.xrLabel21.Dpi = 96F;
            this.xrLabel21.EditOptions.Enabled = true;
            this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Yuzolcumu]")});
            this.xrLabel21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(585.48F, 280.8001F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(125.76F, 26F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel21.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel21_BeforePrint);
            // 
            // xrLabel20
            // 
            this.xrLabel20.CanGrow = false;
            this.xrLabel20.Dpi = 96F;
            this.xrLabel20.EditOptions.Enabled = true;
            this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FenKayitTarihiNo]")});
            this.xrLabel20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(585.36F, 249.1202F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(124.8F, 25.99998F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel20.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel20_BeforePrint);
            // 
            // xrLabel19
            // 
            this.xrLabel19.CanGrow = false;
            this.xrLabel19.Dpi = 96F;
            this.xrLabel19.EditOptions.Enabled = true;
            this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaftaNo]")});
            this.xrLabel19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(585.48F, 217.4802F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(125.76F, 26F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel19.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel19_BeforePrint);
            // 
            // xrLabel18
            // 
            this.xrLabel18.CanGrow = false;
            this.xrLabel18.Dpi = 96F;
            this.xrLabel18.EditOptions.Enabled = true;
            this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AdaParselNo]")});
            this.xrLabel18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(585.48F, 187.7201F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(125.76F, 26F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel18.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel18_BeforePrint);
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.Dpi = 96F;
            this.xrLabel17.EditOptions.Enabled = true;
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GenelToplam]")});
            this.xrLabel17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(480.48F, 616.0801F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(144F, 24F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel17.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel17_BeforePrint);
            // 
            // xrLabel16
            // 
            this.xrLabel16.CanGrow = false;
            this.xrLabel16.Dpi = 96F;
            this.xrLabel16.EditOptions.Enabled = true;
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KDV]")});
            this.xrLabel16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(480.48F, 589.2001F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(144F, 24F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel16.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel16_BeforePrint);
            // 
            // xrLabel15
            // 
            this.xrLabel15.CanGrow = false;
            this.xrLabel15.Dpi = 96F;
            this.xrLabel15.EditOptions.Enabled = true;
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Toplam]")});
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(480.48F, 564.2401F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(144F, 22.08002F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel15.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel15_BeforePrint);
            // 
            // xrLabel14
            // 
            this.xrLabel14.CanGrow = false;
            this.xrLabel14.Dpi = 96F;
            this.xrLabel14.EditOptions.Enabled = true;
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MalikiIBAdiSoyadi]")});
            this.xrLabel14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(224.48F, 280.8801F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(144F, 26F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel14.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel14_BeforePrint);
            // 
            // xrLabel13
            // 
            this.xrLabel13.CanGrow = false;
            this.xrLabel13.Dpi = 96F;
            this.xrLabel13.EditOptions.Enabled = true;
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Koy_Mahalle]")});
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(224.48F, 248.1202F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(144F, 27.99998F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel13.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel13_BeforePrint);
            // 
            // xrLabel12
            // 
            this.xrLabel12.CanGrow = false;
            this.xrLabel12.Dpi = 96F;
            this.xrLabel12.EditOptions.Enabled = true;
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Ilce]")});
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(224.48F, 217.4802F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(144F, 26F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel12.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel12_BeforePrint);
            // 
            // xrLabel11
            // 
            this.xrLabel11.CanGrow = false;
            this.xrLabel11.Dpi = 96F;
            this.xrLabel11.EditOptions.Enabled = true;
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IlinAdi]")});
            this.xrLabel11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(224.48F, 187.7201F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(144F, 26F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel11.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel11_BeforePrint);
            // 
            // xrLabel10
            // 
            this.xrLabel10.CanGrow = false;
            this.xrLabel10.Dpi = 96F;
            this.xrLabel10.EditOptions.Enabled = true;
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OdaSicilNo]")});
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(167.64F, 745.52F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(172.6401F, 24F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel10.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel10_BeforePrint);
            // 
            // xrLabel9
            // 
            this.xrLabel9.CanGrow = false;
            this.xrLabel9.Dpi = 96F;
            this.xrLabel9.EditOptions.Enabled = true;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansliBelgeNo]")});
            this.xrLabel9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(167.64F, 719.6F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(172.6401F, 24F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel9.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel9_BeforePrint);
            // 
            // xrLabel8
            // 
            this.xrLabel8.CanGrow = false;
            this.xrLabel8.Dpi = 96F;
            this.xrLabel8.EditOptions.Enabled = true;
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansliBuroNo]")});
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(167.64F, 693.6801F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(172.6401F, 24F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel8.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel8_BeforePrint);
            // 
            // xrLabel7
            // 
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.Dpi = 96F;
            this.xrLabel7.EditOptions.Enabled = true;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansSahibi_AdiSoyadi]")});
            this.xrLabel7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(167.64F, 667.76F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(172.6401F, 24F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel7.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel7_BeforePrint);
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel6.CanGrow = false;
            this.xrLabel6.Dpi = 96F;
            this.xrLabel6.EditOptions.Enabled = true;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IsSahibiAdress]")});
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(468.48F, 745.52F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(242.64F, 26F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel6.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel6_BeforePrint);
            // 
            // xrLabel5
            // 
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.Dpi = 96F;
            this.xrLabel5.EditOptions.Enabled = true;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IsSahibiTelefon1]")});
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(468.48F, 720.5601F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(242.64F, 24F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel5.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel5_BeforePrint);
            // 
            // xrLabel4
            // 
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.Dpi = 96F;
            this.xrLabel4.EditOptions.Enabled = true;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IsSahibiTCkimlik_VergiNo]")});
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(468.48F, 694.64F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(242.64F, 24F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel4.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel4_BeforePrint);
            // 
            // xrLabel3
            // 
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.Dpi = 96F;
            this.xrLabel3.EditOptions.Enabled = true;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IsSahibiVeUnvani]")});
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(468.48F, 667.72F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(242.64F, 26F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel3.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel3_BeforePrint);
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Dpi = 96F;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansliBuroNo]")});
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(137.44F, 153.84F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(30.03999F, 24F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel1_BeforePrint);
            // 
            // xrLabel2
            // 
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.Dpi = 96F;
            this.xrLabel2.EditOptions.Enabled = true;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansSahibi_AdiSoyadi]")});
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(277.44F, 156.7201F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(122.28F, 26F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel2_BeforePrint);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // GroupCaption3
            // 
            this.GroupCaption3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.GroupCaption3.BorderColor = System.Drawing.Color.White;
            this.GroupCaption3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupCaption3.BorderWidth = 2F;
            this.GroupCaption3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.GroupCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupCaption3.Name = "GroupCaption3";
            this.GroupCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 96F);
            this.GroupCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupData3
            // 
            this.GroupData3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.GroupData3.BorderColor = System.Drawing.Color.White;
            this.GroupData3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupData3.BorderWidth = 2F;
            this.GroupData3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.GroupData3.ForeColor = System.Drawing.Color.White;
            this.GroupData3.Name = "GroupData3";
            this.GroupData3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 96F);
            this.GroupData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            // 
            // ParametreIsId
            // 
            this.ParametreIsId.Description = "Is Id";
            this.ParametreIsId.Name = "ParametreIsId";
            this.ParametreIsId.Type = typeof(int);
            this.ParametreIsId.ValueInfo = "42";
            this.ParametreIsId.Visible = false;
            // 
            // Xtra_TeknikHizmetSozlesmesi
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.efDataSource1});
            this.DataMember = "View_RaporSozlesme";
            this.DataSource = this.efDataSource1;
            this.Dpi = 96F;
            this.FilterString = "[IsId] = ?ParametreIsId";
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 1124);
            this.PageColor = System.Drawing.Color.Transparent;
            this.PageHeight = 1123;
            this.PageWidth = 794;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.ParametreIsId});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels;
            this.RequestParameters = false;
            this.SnapGridSize = 12.5F;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption3,
            this.GroupData3,
            this.PageInfo});
            this.Version = "17.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Xtra_TeknikHizmetSozlesmesi_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private void Xtra_TeknikHizmetSozlesmesi_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XtraReportBase report = (sender as XRControl).Report;
            int isinCinsiId = report.GetCurrentColumnValue<int>("IsinCinsiId");

            HideLabels();

            //1   APLİKASYON
            //2   APLİKASYON / ALTI AY İÇİNDE AYNI YERE KROKI TALEBİ
            //4   BIRLESTIRME
            //5   CINS DEGISIKLIGI / AYNI YAPI UZERINDE KAT ILAVESI
            //6   CINS DEGISIKLIGI / BINA YAPIMI VE YIKIMI ILE ILGILI OLMAYAN VASIF DONUSTURULMESI
            //7   CINS DEGISIKLIGI / YAPILI IKEN YAPISIZ HALE GELME(2010 / 4 SAYILI GENELGE)
            //8   CINS DEGISIKLIGI / YAPISIZ IKEN YAPILI HALE GELME
            //11  HATALI BAGIMSIZ DUZELTME ISLEMI
            //12  IRTIFAK HAKKI
            //13  KADASTRAL YOL SINIRLARININ BELIRLENMESI
            //14  ROPERLI KROKI
            //15  VAZIYET PLANI, BAGIMSIZ BOLUM PLANI
            //16  YAPI APPLIKASYON PROJESI
            //17  YER GOSTERME / BAGIMSIZ BOLUM
            //18  YER GOSTERME / PARSEL

            if (isinCinsiId == 1 || isinCinsiId == 2) // APLİKASYON
            {
                xrLabelApplikasyonCarpi.ForeColor = System.Drawing.Color.Black;
                xrLabelToplamApplk.ForeColor = System.Drawing.Color.Black;
                return;
            }

            if (isinCinsiId == 4) // BIRLESTIRME
            {
                xrLabelBirlestirmeCarpi.ForeColor = System.Drawing.Color.Black;
                xrLabelToplamBirlestirme.ForeColor = System.Drawing.Color.Black;
                return;
            }

            if (isinCinsiId == 12) // IRTIFAK HAKKI
            {
                xrLabelIrtifakHakkiTerkiniCarpi.ForeColor = System.Drawing.Color.Black;
                xrLabelToplamIrtifakHakki.ForeColor = System.Drawing.Color.Black;
                return;
            }

            if (isinCinsiId == 8) // CINS DEGISIKLIGI / YAPISIZ IKEN YAPILI HALE GELME
            {
                xrLabelCinsDegisikligi1.ForeColor = System.Drawing.Color.Black;
                xrLabelToplamCinsDegis.ForeColor = System.Drawing.Color.Black;
                return;
            }

            if (isinCinsiId == 7) // CINS DEGISIKLIGI / YAPILI IKEN YAPISIZ HALE GELME(2010 / 4 SAYILI GENELGE)
            {
                xrLabelCinsDegisikligi2.ForeColor = System.Drawing.Color.Black;
                xrLabelToplamCinsDegis.ForeColor = System.Drawing.Color.Black;
                return;
            }

            if (isinCinsiId == 17) // YER GOSTERME / BAGIMSIZ BOLUM
            {
                xrLabelYerGosterme1.ForeColor = System.Drawing.Color.Black;
                xrLabelToplamYerGosterme.ForeColor = System.Drawing.Color.Black;
                return;
            }

            if (isinCinsiId == 18) // YER GOSTERME / PARSEL
            {
                xrLabelCinsDegisikligi2.ForeColor = System.Drawing.Color.Black;
                xrLabelToplamYerGosterme.ForeColor = System.Drawing.Color.Black;
                return;
            }

        }

        public void HideLabels()
        {
            xrLabelApplikasyonCarpi.ForeColor = System.Drawing.Color.Transparent;
            xrLabelIrtifakHakkiTerkiniCarpi.ForeColor = System.Drawing.Color.Transparent;
            xrLabelIrtifakHakkiTesisiCarpi.ForeColor = System.Drawing.Color.Transparent;
            xrLabelBirlestirmeCarpi.ForeColor = System.Drawing.Color.Transparent;
            xrLabelCinsDegisikligi1.ForeColor = System.Drawing.Color.Transparent;
            xrLabelCinsDegisikligi2.ForeColor = System.Drawing.Color.Transparent;
            xrLabelYerGosterme1.ForeColor = System.Drawing.Color.Transparent;
            xrLabelYerGosterme2.ForeColor = System.Drawing.Color.Transparent;

            xrLabelToplamYerGosterme.ForeColor = System.Drawing.Color.Transparent;
            xrLabelToplamIrtifakHakki.ForeColor = System.Drawing.Color.Transparent;
            xrLabelToplamBirlestirme.ForeColor = System.Drawing.Color.Transparent;
            xrLabelToplamCinsDegis.ForeColor = System.Drawing.Color.Transparent;
            xrLabelToplamApplk.ForeColor = System.Drawing.Color.Transparent;
        }

        public void OrganizeLabels(XRLabel label, float heighLimit)
        {
            Codes.Helpers.ReportHelpers.AutoscaleControlText(label, this, heighLimit);
            label.HeightF = 25; // bu yukseklik iki satir icin gereken yukseklik
            //label.BackColor = System.Drawing.Color.Pink;
            label.CanGrow = true; // bu olmazsa print oncesi ikinci satir cikmiyor
            label.CanShrink = false; // false olmali, bu TRUE olursa labellara sabit bir yukseklik verilemiyor, o yuzden kafasina gore yukari asagi gidiyor.
        }

        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            OrganizeLabels((XRLabel)sender, 25);

        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //adress label
            OrganizeLabels((XRLabel)sender, 25);

        }

        private void xrLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel12_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 23);
        }

        private void xrLabel13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 23);
        }

        private void xrLabel18_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel20_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel22_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Isin cinsi
            OrganizeLabels((XRLabel)sender, 24);
        }

        private void xrLabelToplamApplk_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabelToplamCinsDegis_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabelToplamBirlestirme_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabelToplamIrtifakHakki_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabelToplamYerGosterme_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel16_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel17_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel24_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // License sahibi il
            OrganizeLabels((XRLabel)sender, 25);

        }

        private void xrLabel25_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel26_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // license no
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel23_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel27_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel28_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 20);
        }

        private void xrLabel14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OrganizeLabels((XRLabel)sender, 25);
        }

        private void xrLabel35_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // license no
            OrganizeLabels((XRLabel)sender, 25);

        }

    }

}
