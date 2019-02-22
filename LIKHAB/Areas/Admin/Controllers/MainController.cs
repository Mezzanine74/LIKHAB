using LIKHAB.DataLayer.Configuration;
using LIKHAB.DataLayer.DBContext;
using LIKHAB.DataLayer.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LIKHAB.Areas.Admin.Controllers
{
    [Authorize(Roles = nameof(BusinessLogic.Helpers.RoleNames.Administrator))]
    public class MainController : Controller
    {

        ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                Object a = new Object();

                if (_userManager == null)
                {
                    _userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                }
                return _userManager;
            }
        }

        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }

        // GRIDVIEW KULLANICILAR
        LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities();

        [ValidateInput(false)]
        public ActionResult GridViewPartialUser()
        {
            var model = db.AspNetUsers;
            return PartialView("_GridViewPartialUser", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUserAddNew(LIKHAB.Models.db.AspNetUsers item)
        {
            var model = db.AspNetUsers;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartialUser", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUserUpdate(LIKHAB.Models.db.AspNetUsers item)
        {
            var model = db.AspNetUsers;
            if (ModelState.IsValid)
            {
                try
                {

                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
                    var _user = new ApplicationUser();

                    _user = userManager.FindById(item.Id);

                    if (_user != null)
                    {
                        _user.Email = item.Email;
                        _user.UserName = item.UserName;
                        _user.AdiSoyadi = item.AdiSoyadi;

                        var osmanAbi = userManager.Update(_user);

                    }

                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartialUser", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUserDelete(string id)
        {
            var model = db.AspNetUsers;
            if (id != null)
            {
                try
                {

                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
                    var _user = new ApplicationUser();

                    _user = userManager.FindById(id);

                    if (_user != null)
                    {
                        userManager.Delete(_user);
                    }


                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartialUser", model.ToList());
        }

        // GRIDVIEW ROLLER
        LIKHAB.Models.db.LIHKAB_dbEntities db1 = new LIKHAB.Models.db.LIHKAB_dbEntities();

        [ValidateInput(false)]
        public ActionResult GridViewPartialRoles()
        {
            var model = db1.AspNetRoles;

            return PartialView("~/Areas/Admin/Views/Main/_GridViewPartialRoles.cshtml", model.ToList());
        }

        ApplicationRoleManager _roleManager;
        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ??
                    HttpContext.GetOwinContext()
                    .GetUserManager<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialRolesAddNew(LIKHAB.Models.db.AspNetRoles item)
        {
            var model = db1.AspNetRoles;
            if (ModelState.IsValid)
            {
                try
                {

                    var roleManager = new RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
                    if (!roleManager.RoleExists(item.Name))
                    {
                        var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                        role.Name = item.Name;
                        roleManager.Create(role);
                    }

                    //model.Add(item);
                    //db1.SaveChanges();

                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Areas/Admin/Views/Main/_GridViewPartialRoles.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialRolesUpdate(LIKHAB.Models.db.AspNetRoles item)
        {
            var model = db1.AspNetRoles;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.Id == item.Id);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db1.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Areas/Admin/Views/Main/_GridViewPartialRoles.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialRolesDelete(string id)
        {
            var model = db1.AspNetRoles;
            if (id != null)
            {
                try
                {
                    var roleManager = new RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

                    var _role = new IdentityRole();
                    _role = roleManager.FindById(id);

                    if (roleManager.RoleExists(_role.Name))
                    {
                        roleManager.Delete(_role);
                    }

                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }

            return PartialView("~/Areas/Admin/Views/Main/_GridViewPartialRoles.cshtml", model.ToList());
        }
    }
}