using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.Mvc;
using LIKHAB.BusinessLogic.Helpers;
using LIKHAB.Common;
using LIKHAB.DataLayer;
using System;
using System.Linq;
using System.Web.Mvc;

namespace LIKHAB.Areas.Islemler.Controllers
{
    //[Authorize]
    public class RandevuController : Controller
    {

        public ActionResult Ajanda()
        {
            return View("Ajanda");
        }

        [Authorize(Roles = nameof(LIKHAB.BusinessLogic.Helpers.RoleNames.Aktif))]
        public ActionResult RandevuVer(int id = 0)
        {
            return View("RandevuVer");
        }

        [Authorize(Roles = nameof(LIKHAB.BusinessLogic.Helpers.RoleNames.Patron))]
        public ActionResult RandevuOnayla(int id = 0)
        {
            return View("RandevuOnayla");
        }

        // RANDEVU VER
        LIKHAB.Models.db.LIHKAB_dbEntities appointmentContext = new LIKHAB.Models.db.LIHKAB_dbEntities();
        object resourceContext = null;

        public ActionResult SchedulerRandevuVerPartial(int id = 0)
        {
            var appointments = appointmentContext.Randevu;
            System.Collections.IEnumerable resources = null; // Get resources from the context

            ViewData["Appointments"] = appointments.ToList();
            ViewData["Resources"] = resources;

            bool randevuExists = true;

            if (id != 0)
            {
                randevuExists = Randevu.GetRandevuByIsId(id) != null ? true : false;
            }

            ViewBag.RandevuExists = randevuExists;

            string subjectHint = "";

            using (LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities())
            {
                var a = db.Isler.FirstOrDefault(c => c.id == id);
                if (a != null)
                    subjectHint = a.IsinCinsi1.Tanim + " - " + a.Musteri1.AdiSoyadi;
            }

            ViewBag.SubjectHint = subjectHint;

            return PartialView("_SchedulerRandevuVerPartial");
        }

        public ActionResult SchedulerRandevuVerPartialEditAppointment(int id = 0)
        {
            var appointments = appointmentContext.Randevu;
            System.Collections.IEnumerable resources = null; // Get resources from the context

            try
            {
                RandevuControllerSchedulerRandevuVerSettings.UpdateEditableDataObject(appointmentContext, resourceContext, id);
            }
            catch (Exception e)
            {
                ViewData["SchedulerErrorText"] = e.Message;
            }

            ViewData["Appointments"] = appointments.ToList();
            ViewData["Resources"] = resources;

            bool randevuExists = true;

            if (id != 0)
            {
                randevuExists = Randevu.GetRandevuByIsId(id) != null ? true : false;
            }

            ViewBag.RandevuExists = randevuExists;


            return PartialView("_SchedulerRandevuVerPartial");
        }

        // RANDEVU ONAYLA
        LIKHAB.Models.db.LIHKAB_dbEntities appointmentContext1 = new LIKHAB.Models.db.LIHKAB_dbEntities();
        object resourceContext1 = null;

        public ActionResult SchedulerRandevuOnayPartial(int id = 0, int isId = 0)
        {
            //var appointments = appointmentContext1.Randevu;

            //var appointments = from C in appointmentContext1.Randevu join D in appointmentContext1.ViewRandevularIsBilgisiOlmayan on C.id equals D.id select C;
            var appointments = appointmentContext1.Randevu;

            System.Collections.IEnumerable resources = null; // Get resources from the context

            ViewData["Appointments"] = appointments.ToList();
            ViewData["Resources"] = resources;


            var randevuGirilebilirMi = new Randevu.RandevuGirisValidation();
            ViewBag.RandevuGirilebilirMi = Randevu.RandevuGirilebilirMi(isId);

            string subjectHint = "";

            using (LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities())
            {
                var a = db.Isler.FirstOrDefault(c => c.id == isId);
                if (a != null)
                    subjectHint = a.IsinCinsi1.Tanim + " - " + a.Musteri1.AdiSoyadi;
            }

            ViewBag.SubjectHint = subjectHint;

            return PartialView("_SchedulerRandevuOnayPartial");
        }

        public ActionResult SchedulerRandevuOnayPartialEditAppointment(int id = 0, int isId = 0)
        {
            var appointments = appointmentContext1.Randevu;
            System.Collections.IEnumerable resources = null; // Get resources from the context

            try
            {
                RandevuControllerSchedulerRandevuOnaySettings.UpdateEditableDataObject(appointmentContext1, resourceContext1, isId);
            }
            catch (Exception e)
            {
                ViewData["SchedulerErrorText"] = e.Message;
            }

            ViewData["Appointments"] = appointments.ToList();
            ViewData["Resources"] = resources;

            // giris validation
            var randevuGirilebilirMi = new Randevu.RandevuGirisValidation();
            ViewBag.RandevuGirilebilirMi = Randevu.RandevuGirilebilirMi(isId);

            return PartialView("_SchedulerRandevuOnayPartial");
        }

        // RANDEVU AJANDA
        LIKHAB.Models.db.LIHKAB_dbEntities appointmentContextAjanda = new LIKHAB.Models.db.LIHKAB_dbEntities();
        object resourceContextAjanda = null;

        public ActionResult SchedulerPartialAjanda()
        {

            var appointments = appointmentContextAjanda.Randevu;

            System.Collections.IEnumerable resources = null; // Get resources from the context

            ViewData["Appointments"] = appointments.ToList();
            ViewData["Resources"] = resources;

            return PartialView("_SchedulerPartialAjanda");
        }

        LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities();

        // RANDEVU DETAY
        [ValidateInput(false)]
        public ActionResult VerticalGridPartialRandevuDetay(int id = 0) // id simdilik iptal
        {
            //var model = from c in db.Randevu join d in db.ViewRandevularIsBilgisiOlmayan on c.id equals d.id select c;
            var model = db.Randevu;
            return PartialView("_VerticalGridPartialRandevuDetay", model.ToList());
        }

        LIKHAB.Models.db.LIHKAB_dbEntities db1 = new LIKHAB.Models.db.LIHKAB_dbEntities();

        // GRIDVIEW RANDEVU ONAY
        [ValidateInput(false)]
        public ActionResult GridViewPartialRandevuOnayDurumu(int id = 0)
        {
            int filter = 0;

            if (id > 0) { Session["id"] = id; filter = id; } else { filter = (int)Session["id"]; };

            var model = db1.ViewRandevuOnayDurumu.Where(c => c.RandevuId == filter);
            return PartialView("_GridViewPartialRandevuOnayDurumu", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialRandevuOnayDurumuAddNew(LIKHAB.Models.db.ViewRandevuOnayDurumu item)
        {
            var model = db1.ViewRandevuOnayDurumu;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db1.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartialRandevuOnayDurumu", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialRandevuOnayDurumuUpdate(LIKHAB.Models.db.ViewRandevuOnayDurumu item, int onayKodu = 0, string userId = "", int onaylananSatirId = 0)
        {
            // process entry

            bool a = Onay.ProcessOnayEntry(onayKodu, userId, onaylananSatirId);

            ViewData["onayMesaji"] = "";

            if (a)
            {
                string emailKimeGonderildi = "";

                var emailsGeriBildirim = (from c in db.Randevu join d in db.AspNetUsers on c.WhoCreated equals d.AdiSoyadi where c.id == onaylananSatirId select d.AdiSoyadi).ToList();

                if (emailsGeriBildirim.Count() == 0)
                {
                    emailKimeGonderildi = UserInfo.GetDefaulEmailOnayGeriBildirim();
                }
                else
                {
                    foreach (string i in emailsGeriBildirim)
                    {
                        emailKimeGonderildi = " (" + i + ") ";
                    }
                }

                ViewData["onayMesaji"] = "Onaylandi! Randevuyu olusturan " + emailKimeGonderildi + " email ile bilgilendirilmistir.";

            }

            int filter = onaylananSatirId != 0 ? onaylananSatirId : (int)Session["id"];

            var model = db1.ViewRandevuOnayDurumu.Where(c => c.RandevuId == filter);

            return PartialView("_GridViewPartialRandevuOnayDurumu", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialRandevuOnayDurumuDelete(System.Int64 UniqueId)
        {
            var model = db1.ViewRandevuOnayDurumu;
            if (UniqueId >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.UniqueId == UniqueId);
                    if (item != null)
                        model.Remove(item);
                    db1.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartialRandevuOnayDurumu", model.ToList());
        }

    }

    // RANDEVU VER SETTINGS
    public class RandevuControllerSchedulerRandevuVerSettings
    {
        private static DateTime _localTime;

        public RandevuControllerSchedulerRandevuVerSettings()
        {
            _localTime = LocalTime.GetIstanbul();
        }

        static DevExpress.Web.Mvc.MVCxAppointmentStorage appointmentStorage;
        public static DevExpress.Web.Mvc.MVCxAppointmentStorage AppointmentStorage
        {
            get
            {
                if (appointmentStorage == null)
                {
                    appointmentStorage = new DevExpress.Web.Mvc.MVCxAppointmentStorage();
                    appointmentStorage.Mappings.AppointmentId = "id";
                    appointmentStorage.Mappings.Start = "StartDate";
                    appointmentStorage.Mappings.End = "EndDate";
                    appointmentStorage.Mappings.Subject = "Subject";
                    appointmentStorage.Mappings.Description = "Description";
                    appointmentStorage.Mappings.Location = "Location";
                    appointmentStorage.Mappings.AllDay = "AllDay";
                    appointmentStorage.Mappings.Type = "Type";
                    appointmentStorage.Mappings.Label = "Label";
                    appointmentStorage.Mappings.Status = "Status";
                    appointmentStorage.CustomFieldMappings.Add("Is", "Is"); // IsId nin update olmasi icin sart, yoksa NULL olur
                    appointmentStorage.CustomFieldMappings.Add("WhoCreated", "WhoCreated");

                    var etiketler = new LIKHAB.Codes.Helpers.Etiketler();
                    etiketler.EtiketleriEkle(appointmentStorage);

                }
                return appointmentStorage;
            }
        }

        public class CustomAppointmentTemplateContainer : AppointmentFormTemplateContainer
        {
            public CustomAppointmentTemplateContainer(MVCxScheduler scheduler) : base(scheduler) { }

        }

        static DevExpress.Web.Mvc.MVCxResourceStorage resourceStorage;
        public static DevExpress.Web.Mvc.MVCxResourceStorage ResourceStorage
        {
            get
            {
                if (resourceStorage == null)
                {
                    resourceStorage = new DevExpress.Web.Mvc.MVCxResourceStorage();
                    resourceStorage.Mappings.ResourceId = "";
                    resourceStorage.Mappings.Caption = "";
                }
                return resourceStorage;
            }
        }

        public static void UpdateEditableDataObject(LIKHAB.Models.db.LIHKAB_dbEntities appointmentContext, object resourceContext, int id)
        {
            InsertAppointments(appointmentContext, resourceContext, id);
            UpdateAppointments(appointmentContext, resourceContext);
            DeleteAppointments(appointmentContext, resourceContext);
        }

        static void InsertAppointments(LIKHAB.Models.db.LIHKAB_dbEntities appointmentContext, object resourceContext, int id)
        {
            var appointments = appointmentContext.Randevu.ToList();
            System.Collections.IEnumerable resources = null;

            var newAppointments = DevExpress.Web.Mvc.SchedulerExtension.GetAppointmentsToInsert<LIKHAB.Models.db.Randevu>("SchedulerRandevuVer", appointments, resources,
                AppointmentStorage, ResourceStorage);
            foreach (var appointment in newAppointments)
            {
                if (appointmentContext.Randevu.Where(c => c.Is == id).ToList().Count() == 0) // bu is icin appointment henuz yoksa
                {

                    appointment.Is = id; // IdIs comes here
                    appointment.WhoCreated = UserInfo.GetAdiSoyadiOfCurrentUser();
                    appointment.WhenCreated = _localTime;

                    // Randevunun ilk halini ayri tabloya ekle
                    var ilkHali = new LIKHAB.Models.db.RandevuIlkHali()
                    {
                        AllDay = appointment.AllDay,
                        Description = appointment.Description,
                        EndDate = appointment.EndDate,
                        Is = appointment.Is,
                        Location = appointment.Location,
                        StartDate = appointment.StartDate,
                        Title = appointment.Title,
                        Type = appointment.Type,
                        Subject = appointment.Subject,
                        Status = appointment.Status,
                        Label = appointment.Label,
                        VerilisZamani = _localTime,
                        AdiSoyadi = System.Web.HttpContext.Current.User.Identity.Name,
                        WhoCreated = UserInfo.GetAdiSoyadiOfCurrentUser(),
                        WhenCreated = _localTime
                    };

                    appointmentContext.Randevu.Add(appointment);
                    appointmentContext.RandevuIlkHali.Add(ilkHali);

                }
            }
            appointmentContext.SaveChanges();
        }

        static void UpdateAppointments(LIKHAB.Models.db.LIHKAB_dbEntities appointmentContext, object resourceContext)
        {
            var appointments = appointmentContext.Randevu.ToList();
            System.Collections.IEnumerable resources = null;

            var updAppointments = DevExpress.Web.Mvc.SchedulerExtension.GetAppointmentsToUpdate<LIKHAB.Models.db.Randevu>("SchedulerRandevuVer", appointments, resources,
                AppointmentStorage, ResourceStorage);
            foreach (var appointment in updAppointments)
            {
                var origAppointment = appointments.FirstOrDefault(a => a.id == appointment.id);

                // label ve status burada yok ve olmayacak. cunku kullanici bunu degistiremez, otomatik degisecek
                origAppointment.AllDay = appointment.AllDay;
                origAppointment.Description = appointment.Description;
                origAppointment.EndDate = appointment.EndDate;
                origAppointment.Is = appointment.Is;
                origAppointment.Location = appointment.Location;
                origAppointment.StartDate = appointment.StartDate;
                origAppointment.Subject = appointment.Subject;
                origAppointment.Title = appointment.Title;
                origAppointment.Type = appointment.Type;
                origAppointment.WhoUpdated = UserInfo.GetAdiSoyadiOfCurrentUser();
                origAppointment.WhenUpdated = _localTime;

                appointmentContext.SaveChanges();
            }
            appointmentContext.SaveChanges();
        }

        static void DeleteAppointments(LIKHAB.Models.db.LIHKAB_dbEntities appointmentContext, object resourceContext)
        {
            var appointments = appointmentContext.Randevu.ToList();
            System.Collections.IEnumerable resources = null;

            var delAppointments = DevExpress.Web.Mvc.SchedulerExtension.GetAppointmentsToRemove<LIKHAB.Models.db.Randevu>("SchedulerRandevuVer", appointments, resources,
                AppointmentStorage, ResourceStorage);
            foreach (var appointment in delAppointments)
            {
                var delAppointment = appointments.FirstOrDefault(a => a.id == appointment.id);
                if (delAppointment != null)
                    appointmentContext.Randevu.Remove(delAppointment);
            }
            appointmentContext.SaveChanges();
        }
    }

    // RANDEVU ONAYLA SETTINGS
    public class RandevuControllerSchedulerRandevuOnaySettings
    {
        private static DateTime _localTime;

        public RandevuControllerSchedulerRandevuOnaySettings()
        {
            _localTime = LocalTime.GetIstanbul();
        }

        static DevExpress.Web.Mvc.MVCxAppointmentStorage appointmentStorage;
        public static DevExpress.Web.Mvc.MVCxAppointmentStorage AppointmentStorage
        {
            get
            {
                if (appointmentStorage == null)
                {
                    appointmentStorage = new DevExpress.Web.Mvc.MVCxAppointmentStorage();
                    appointmentStorage.Mappings.AppointmentId = "id";
                    appointmentStorage.Mappings.Start = "StartDate";
                    appointmentStorage.Mappings.End = "EndDate";
                    appointmentStorage.Mappings.Subject = "Subject";
                    appointmentStorage.Mappings.Description = "Description";
                    appointmentStorage.Mappings.Location = "Location";
                    appointmentStorage.Mappings.AllDay = "AllDay";
                    appointmentStorage.Mappings.Type = "Type";
                    appointmentStorage.Mappings.Label = "Label";
                    appointmentStorage.Mappings.Status = "Status";
                    appointmentStorage.CustomFieldMappings.Add("Is", "Is"); // IsId nin update olmasi icin sart, yoksa NULL olur

                    var etiketler = new Codes.Helpers.Etiketler();
                    etiketler.EtiketleriEkle(appointmentStorage);

                }
                return appointmentStorage;
            }
        }

        public class CustomAppointmentTemplateContainer : AppointmentFormTemplateContainer
        {
            public CustomAppointmentTemplateContainer(MVCxScheduler scheduler) : base(scheduler) { }

            public bool Onaylanmis
            {
                get
                {
                    return Appointment.CustomFields["AppointmentCustomField"] != null ? (bool)Appointment.CustomFields["AppointmentCustomField"] : false;
                }
            }
            public Nullable<System.DateTime> OnayZamani
            {
                get
                {
                    return (Nullable<System.DateTime>)Appointment.CustomFields["AppointmentCustomFieldOnayZamani"];
                }
            }

        }

        static DevExpress.Web.Mvc.MVCxResourceStorage resourceStorage;
        public static DevExpress.Web.Mvc.MVCxResourceStorage ResourceStorage
        {
            get
            {
                if (resourceStorage == null)
                {
                    resourceStorage = new DevExpress.Web.Mvc.MVCxResourceStorage();
                    resourceStorage.Mappings.ResourceId = "";
                    resourceStorage.Mappings.Caption = "";
                }
                return resourceStorage;
            }
        }

        public static void UpdateEditableDataObject(LIKHAB.Models.db.LIHKAB_dbEntities appointmentContext, object resourceContext, int id)
        {
            InsertAppointments(appointmentContext, resourceContext, id);
            UpdateAppointments(appointmentContext, resourceContext);
            DeleteAppointments(appointmentContext, resourceContext);
        }

        static void InsertAppointments(LIKHAB.Models.db.LIHKAB_dbEntities appointmentContext, object resourceContext, int id)
        {
            var appointments = appointmentContext.Randevu.ToList();
            System.Collections.IEnumerable resources = null;

            var newAppointments = DevExpress.Web.Mvc.SchedulerExtension.GetAppointmentsToInsert<LIKHAB.Models.db.Randevu>("SchedulerRandevuOnay", appointments, resources,
                AppointmentStorage, ResourceStorage);
            foreach (var appointment in newAppointments)
            {
                if (appointmentContext.Randevu.Where(c => c.Is == id).ToList().Count() == 0) // bu is icin appointment henuz yoksa
                {
                    appointment.Is = id; // IdIs comes here

                    using (LIKHAB.Models.db.LIHKAB_dbEntities db = new LIKHAB.Models.db.LIHKAB_dbEntities())
                    {
                        var a = db.IsAsamalari.FirstOrDefault(c => c.IsId == id);
                        if (a != null)
                        {
                            a.OnayaGidisZamani = _localTime;
                        }
                        db.SaveChanges();
                        db.Dispose();
                    }

                    appointmentContext.Randevu.Add(appointment);
                }
            }

            appointmentContext.SaveChanges();
        }
        static void UpdateAppointments(LIKHAB.Models.db.LIHKAB_dbEntities appointmentContext, object resourceContext)
        {
            var appointments = appointmentContext.Randevu.ToList();
            System.Collections.IEnumerable resources = null;

            var updAppointments = DevExpress.Web.Mvc.SchedulerExtension.GetAppointmentsToUpdate<LIKHAB.Models.db.Randevu>("SchedulerRandevuOnay", appointments, resources,
                AppointmentStorage, ResourceStorage);
            foreach (var appointment in updAppointments)
            {
                var origAppointment = appointments.FirstOrDefault(a => a.id == appointment.id);

                // label ve status burada yok ve olmayacak. cunku kullanici bunu degistiremez, otomatik degisecek
                origAppointment.AllDay = appointment.AllDay;
                origAppointment.Description = appointment.Description;
                origAppointment.EndDate = appointment.EndDate;
                origAppointment.Is = appointment.Is;
                origAppointment.Location = appointment.Location;
                origAppointment.StartDate = appointment.StartDate;
                origAppointment.Subject = appointment.Subject;
                origAppointment.Title = appointment.Title;
                origAppointment.Type = appointment.Type;
                origAppointment.WhoUpdated = UserInfo.GetAdiSoyadiOfCurrentUser();
                origAppointment.WhenUpdated = _localTime;

                appointmentContext.SaveChanges();
            }

        }

        static void DeleteAppointments(LIKHAB.Models.db.LIHKAB_dbEntities appointmentContext, object resourceContext)
        {

            var appointments = appointmentContext.Randevu.ToList();
            System.Collections.IEnumerable resources = null;

            var delAppointments = DevExpress.Web.Mvc.SchedulerExtension.GetAppointmentsToRemove<LIKHAB.Models.db.Randevu>("SchedulerRandevuOnay", appointments, resources,
                AppointmentStorage, ResourceStorage);
            foreach (var appointment in delAppointments)
            {
                var delAppointment = appointments.FirstOrDefault(a => a.id == appointment.id);
                if (delAppointment != null)
                    appointmentContext.Randevu.Remove(delAppointment);
            }
            appointmentContext.SaveChanges();
        }
    }

    // RANDEVU AJANDA SETTINGS
    public class RandevuControllerSchedulerAjandaSettings
    {

        static DevExpress.Web.Mvc.MVCxAppointmentStorage appointmentStorage;
        public static DevExpress.Web.Mvc.MVCxAppointmentStorage AppointmentStorage
        {
            get
            {
                if (appointmentStorage == null)
                {
                    appointmentStorage = new DevExpress.Web.Mvc.MVCxAppointmentStorage();
                    appointmentStorage.Mappings.AppointmentId = "id";
                    appointmentStorage.Mappings.Start = "StartDate";
                    appointmentStorage.Mappings.End = "EndDate";
                    appointmentStorage.Mappings.Subject = "Subject";
                    appointmentStorage.Mappings.Description = "Description";
                    appointmentStorage.Mappings.Location = "Location";
                    appointmentStorage.Mappings.AllDay = "AllDay";
                    appointmentStorage.Mappings.Type = "Type";
                    appointmentStorage.Mappings.Label = "Label";
                    appointmentStorage.Mappings.Status = "Status";
                    appointmentStorage.CustomFieldMappings.Add("Is", "Is"); // IsId nin update olmasi icin sart, yoksa NULL olur

                    var etiketler = new Codes.Helpers.Etiketler();
                    etiketler.EtiketleriEkle(appointmentStorage);

                }
                return appointmentStorage;
            }
        }

        static DevExpress.Web.Mvc.MVCxResourceStorage resourceStorage;
        public static DevExpress.Web.Mvc.MVCxResourceStorage ResourceStorage
        {
            get
            {
                if (resourceStorage == null)
                {
                    resourceStorage = new DevExpress.Web.Mvc.MVCxResourceStorage();
                    resourceStorage.Mappings.ResourceId = "";
                    resourceStorage.Mappings.Caption = "";
                }
                return resourceStorage;
            }
        }
    }
}