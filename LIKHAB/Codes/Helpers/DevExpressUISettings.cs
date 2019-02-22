using DevExpress.Web;

namespace LIKHAB.Codes.Helpers
{
    public class DevExpressUISettings
    {
        public static void GridViewValidationSettings(ASPxEdit e)
        {
            ((ASPxEdit)e).ValidationSettings.Display = Display.Dynamic;
            ((ASPxEdit)e).ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText;
            ((ASPxEdit)e).ValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom;
        }
    }
}