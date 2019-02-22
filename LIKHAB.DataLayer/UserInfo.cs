using LIKHAB.DataLayer.DBContext;
using LIKHAB.DataLayer.Models;
using Microsoft.AspNet.Identity;

namespace LIKHAB.DataLayer
{
    public class UserInfo
    {
        public static string GetUserNameOfCurrentUser()
        {
            return System.Web.HttpContext.Current.User.Identity.Name;
        }

        public static string GetAdiSoyadiOfCurrentUser()
        {
            return GetAdiSoyadiByUserName(System.Web.HttpContext.Current.User.Identity.Name);
        }

        public static string GetDefaulEmailOnayGeriBildirim()
        {
            return "savas.erzin@gmail.com"; // Eger Randevuyu veren NULL ise onay geri bildirimleri bu adrese gider
        }

        public static string GetAdiSoyadiByUserName(string userName)
        {
            var userManager = new UserManager<ApplicationUser>(new Microsoft.AspNet.Identity.EntityFramework.UserStore<ApplicationUser>(new ApplicationDbContext()));
            var user = userManager.FindByName(GetUserNameOfCurrentUser());
            //"N/A"
            return user is null ? "N/A" : user.AdiSoyadi;

        }

        public static bool GetIfCurrentUserInRole(string roleName)
        {
            var userManager = new UserManager<ApplicationUser>(new Microsoft.AspNet.Identity.EntityFramework.UserStore<ApplicationUser>(new ApplicationDbContext()));
            bool ifUserInRole = userManager.IsInRole(userManager.FindByName(GetUserNameOfCurrentUser()).Id, roleName);

            return ifUserInRole;
        }
    }
}