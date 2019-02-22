//Xtra_RandevuOnayTalebiEmail
using DevExpress.XtraReports.UI;

namespace LIKHAB.Reports
{
    /// <summary>
    /// Summary description for Xtra_RandevuOnayTalebiEmail
    /// </summary>
    public class Xtra_TeslimSenedi : DevExpress.XtraReports.UI.XtraReport
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
        private XRLabel xrLabel3;
        private XRLabel xrLabel2;
        private XRLabel xrLabel1;
        private XRLabel xrLabel5;
        private XRLabel xrLabel4;
        private XRLabel xrLabel7;
        private XRLabel xrLabel6;
        private XRLabel xrLabel9;
        private XRLabel xrLabel8;
        private XRLabel xrLabel12;
        private XRLabel xrLabel11;
        private XRLabel xrLabel10;
        private XRPanel xrPanel1;
        private XRLabel xrLabel15;
        private XRLabel xrLabel14;
        private XRLabel xrLabel13;
        private XRPanel xrPanel2;
        private XRLabel xrLabel16;
        private XRLabel xrLabel17;
        private XRPanel xrPanel3;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Xtra_TeslimSenedi()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xtra_TeslimSenedi));
            this.efDataSource1 = new DevExpress.DataAccess.EntityFramework.EFDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(794.8965F, 1123.862F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3,
            this.xrPanel2,
            this.xrPanel1,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.xrPictureBox1});
            this.BottomMargin.Dpi = 96F;
            this.BottomMargin.HeightF = 1124F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPanel3
            // 
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13});
            this.xrPanel3.Dpi = 96F;
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(67F, 584.96F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(665F, 72F);
            // 
            // xrLabel15
            // 
            this.xrLabel15.Dpi = 96F;
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ToplamFiyat]")});
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(380F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(102F, 22.08F);
            this.xrLabel15.StylePriority.UseFont = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Dpi = 96F;
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BirimFiyati]")});
            this.xrLabel14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(270F, 0F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(103F, 22.08F);
            this.xrLabel14.StylePriority.UseFont = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Dpi = 96F;
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cinsi]")});
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(29F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(129F, 22.08F);
            this.xrLabel13.StylePriority.UseFont = false;
            // 
            // xrPanel2
            // 
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel17});
            this.xrPanel2.Dpi = 96F;
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(447F, 797F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(223F, 49.99997F);
            // 
            // xrLabel16
            // 
            this.xrLabel16.Dpi = 96F;
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansliBuroSahibiUnvani]")});
            this.xrLabel16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(11F, 24.03998F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(189F, 12.08F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Dpi = 96F;
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansliBuroSahibi]")});
            this.xrLabel17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10.95996F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(192F, 13.08F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrLabel9,
            this.xrLabel8});
            this.xrPanel1.Dpi = 96F;
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(67F, 412.96F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(665F, 111F);
            // 
            // xrLabel12
            // 
            this.xrLabel12.Dpi = 96F;
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[isSahibi]")});
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(408F, 10.95996F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(234F, 88.08F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Dpi = 96F;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansliBuroSahibiUnvani]")});
            this.xrLabel9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(11F, 24.03998F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(189F, 12.08F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Dpi = 96F;
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LisansliBuroSahibi]")});
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10.95996F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(192F, 13.08F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Dpi = 96F;
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FenKayitTarihiYIL]")});
            this.xrLabel11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(605F, 336.96F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(41F, 22.08F);
            this.xrLabel11.StylePriority.UseFont = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Dpi = 96F;
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FenKayitTarihiAY]")});
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(579F, 336.96F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(21F, 22.08F);
            this.xrLabel10.StylePriority.UseFont = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Dpi = 96F;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FenKayitTarihiGUN]")});
            this.xrLabel7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(552F, 336.96F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(21F, 22.08F);
            this.xrLabel7.StylePriority.UseFont = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Dpi = 96F;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tanim]")});
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(96F, 317.96F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(150F, 69.07999F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel6_BeforePrint);
            // 
            // xrLabel5
            // 
            this.xrLabel5.Dpi = 96F;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YuzOlcumu]")});
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(556F, 236.96F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(100F, 22.08F);
            this.xrLabel5.StylePriority.UseFont = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Dpi = 96F;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ParselNo]")});
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(447F, 236.96F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(101F, 22.08F);
            this.xrLabel4.StylePriority.UseFont = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Dpi = 96F;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AdaNo]")});
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(338F, 236.96F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(101F, 22.08F);
            this.xrLabel3.StylePriority.UseFont = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 96F;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaftaNo]")});
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(230F, 236.96F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(101F, 22.08F);
            this.xrLabel2.StylePriority.UseFont = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 96F;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Koy_Mahalle]")});
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(96F, 236.96F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(129F, 22.08F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel1_BeforePrint);
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
            // Xtra_TeslimSenedi
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.efDataSource1});
            this.DataMember = "ViewTeslimSenedi";
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
            ((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }


        #endregion

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Codes.Helpers.ReportHelpers.AutoscaleControlText((XRLabel)sender, this, 20);
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Codes.Helpers.ReportHelpers.AutoscaleControlText((XRLabel)sender, this, 20);
        }
    }

}
