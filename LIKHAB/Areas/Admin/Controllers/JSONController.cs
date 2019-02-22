using LIKHAB.DataLayer.Configuration;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LIKHAB.Areas.Admin.Controllers
{
    [Authorize]
    public class JSONController : Controller
    {
        private LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities();

        ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                if (_userManager == null)
                {
                    _userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                }
                return _userManager;
            }
        }

        public class ReturnedJson
        {
            public string UserId { get; set; }
            public string AdiSoyadi { get; set; }
            public string RoleId { get; set; }
            public string RoleName { get; set; }
            public string Action { get; set; }
        }

        public enum Action
        {
            ekle,
            cikar,
            na
        }

        [HttpPost]
        public JsonResult ProcessRolesUsers(List<string> usersinRole, string roleId)
        {

            db.Configuration.ProxyCreationEnabled = false;

            var _return = new List<ReturnedJson>();

            if (usersinRole != null)
            {
                foreach (string item in usersinRole)
                {
                    // user rol icinde mi kontrol et
                    int a = (from c in db.AspNetUserRoles
                             join d in db.AspNetUsers on c.UserId equals d.Id
                             where d.AdiSoyadi == item && c.RoleId == roleId
                             select d).ToList().Count();

                    if (a == 0)
                    {

                        // ekle
                        using (LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities())
                        {
                            // find userid and rolenam
                            var user = db.AspNetUsers.First(c => c.AdiSoyadi == item).Id;
                            var roleName = db.AspNetRoles.First(c => c.Id == roleId).Name;

                            _return.Add(new ReturnedJson { UserId = user, AdiSoyadi = item, RoleId = roleId, RoleName = roleName, Action = Action.ekle.ToString() });

                            db.Dispose();
                        }
                    }

                    if (a > 0)
                    {
                        _return.Add(new ReturnedJson { AdiSoyadi = item, RoleId = roleId, Action = Action.na.ToString() });
                    }
                }
            }

            var usersList = new List<string>();

            if (usersinRole == null)
            {
                usersList.Add("impossibleUserName");
            }
            else
            {
                usersList = usersinRole;
            }

            var list = (from user in db.AspNetUsers
                        join userroles in db.AspNetUserRoles on user.Id equals userroles.UserId
                        where userroles.RoleId == roleId && !usersList.Any(f => f == user.AdiSoyadi)
                        select user).ToList();

            foreach (LIKHAB.Models.db.AspNetUsers item in list)
            {
                // sil
                using (LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities())
                {
                    // find userid and rolenam
                    var user = db.AspNetUsers.First(c => c.AdiSoyadi == item.AdiSoyadi).Id;
                    var roleName = db.AspNetRoles.First(c => c.Id == roleId).Name;

                    _return.Add(new ReturnedJson { UserId = user, AdiSoyadi = item.AdiSoyadi, RoleId = roleId, RoleName = roleName, Action = Action.cikar.ToString() });

                    db.Dispose();
                }
            }

            var message = "";

            foreach (ReturnedJson item in _return)
            {
                if (item.Action == Action.ekle.ToString())
                {
                    //UserManager.AddToRole("aac48417-89d6-4ccb-a4f4-757b10d83371", "test");

                    var islem = UserManager.AddToRole(item.UserId, item.RoleName);

                    if (islem.Succeeded)
                    {
                        message += "<" + item.AdiSoyadi + "> <" + item.RoleName + "> rolune eklendi";
                    }
                    else
                    {
                        message += "hata olustu";
                    }

                }

                if (item.Action == Action.cikar.ToString())
                {

                    //UserManager.RemoveFromRole("aac48417-89d6-4ccb-a4f4-757b10d83371", "test");

                    var islem = UserManager.RemoveFromRole(item.UserId, item.RoleName);

                    if (islem.Succeeded)
                    {
                        message += "<" + item.AdiSoyadi + "> <" + item.RoleName + "> rolunden cikarildi";
                    }
                    else
                    {
                        message += "hata olustu";
                    }

                }

            }

            return Json(message, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}