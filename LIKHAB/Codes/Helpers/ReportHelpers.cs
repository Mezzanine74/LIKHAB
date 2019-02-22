using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Drawing;

namespace LIKHAB.Codes.Helpers
{
    public class ReportHelpers
    {

        public static void AutoscaleControlText(XRControl control, XtraReport report, float heightLimit)
        {

            if (control.Tag.ToString() == "1")
            {
                return;
            }

            float width = TakeWidth(control, report);
            float height = TakeHeight(control);

            int fontPixel = 12;
            while (height > heightLimit)
            {
                control.Font = new System.Drawing.Font("Arial", fontPixel, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                height = TakeHeight(control);
                --fontPixel;
            }

            control.Tag = 1;
            return;

        }

        public static float TakeWidth(XRControl control, XtraReport report)
        {
            StringFormat format = (StringFormat)StringFormat.GenericTypographic.Clone();
            format.FormatFlags = System.Drawing.StringFormatFlags.FitBlackBox | System.Drawing.StringFormatFlags.LineLimit | System.Drawing.StringFormatFlags.NoClip;

            String text = control.Text;
            SizeF textSize = SizeF.Empty;

            textSize = report.PrintingSystem.Graph.MeasureString(text, control.Font);
            return textSize.Width;

        }

        public static float TakeHeight(XRControl control)
        {
            StringFormat format = (StringFormat)StringFormat.GenericTypographic.Clone();

            XRLabel label = (XRLabel)control;
            String text = label.Text;
            SizeF textSize = SizeF.Empty;
            float textWidthProvided = 0.0F;

            textWidthProvided = label.WidthF - label.Padding.Left - label.Padding.Right;
            textSize = BrickGraphics.MeasureString(text, label.Font, (int)textWidthProvided, format, GraphicsUnit.Document);

            return (int)Math.Round(textSize.Height, MidpointRounding.AwayFromZero);

        }

    }
}