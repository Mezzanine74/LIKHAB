using LIKHAB.DataLayer.DBContext;
using LIKHAB.DataLayer.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace LIKHAB.Services.Email
{
    public class PrepareEmail
    {
        private static LikhabDBContext _db = new LikhabDBContext();

        static public void AddToWhom(MailMessage mm, EmailNotificationType _type, int islemGorenSatirId, int isId = 0)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            switch (_type)
            {
                case EmailNotificationType.RandevuOnayTalebiGonder:

                    var userIds = _db.OnayVerecekKisis.Where(c => c.OnayTurus.Any(d => d.OnayKodu == (int)LIKHAB.Common.OnayTuru.Randevu))
                        .Select(s => s.UserId).ToList();

                    var emails = new List<string>();

                    foreach (var userId in userIds)
                    {
                        emails.Add(userManager.FindById(userId).Email);
                    }

                    foreach (string item in emails)
                    {
                        mm.To.Add(item);
                    }

                    break;
                case EmailNotificationType.RandevuOnayiniGeriBildir:

                    if (islemGorenSatirId == 0 && isId > 0)
                    {
                        // randevusuz onaylanmis
                        var _is = _db.Islers.FirstOrDefault(c => c.Id == isId);
                        var who = _is is null ? string.Empty : _is.WhoCreated;
                        var emailsGeriBildirim = who == string.Empty ? string.Empty : userManager.FindByName(who).Email;

                        if (emailsGeriBildirim == string.Empty)
                        {
                            mm.To.Add(LIKHAB.DataLayer.UserInfo.GetDefaulEmailOnayGeriBildirim());
                        }
                        else
                        {
                            mm.To.Add(emailsGeriBildirim);
                        }
                    }

                    if (islemGorenSatirId > 0)
                    {
                        // randevulu onaylanmis
                        var randevu = _db.Randevus.FirstOrDefault(c => c.Id == islemGorenSatirId);
                        var who = randevu is null ? string.Empty : randevu.WhoCreated;
                        var emailsGeriBildirim = who == string.Empty ? string.Empty : userManager.FindByName(who).Email;

                        if (emailsGeriBildirim == String.Empty)
                        {
                            mm.To.Add(LIKHAB.DataLayer.UserInfo.GetDefaulEmailOnayGeriBildirim());
                        }
                        else
                        {
                            mm.To.Add(emailsGeriBildirim);
                        }
                    }

                    break;
                case EmailNotificationType.IsBilgileriSilimiGeriBildirimi:
                    var Is = _db.Islers.FirstOrDefault(c => c.Id == isId);
                    var wh = Is is null ? string.Empty : Is.WhoCreated;
                    var emailisiAcan = wh == string.Empty ? string.Empty : userManager.FindByName(wh).Email;

                    if (emailisiAcan == string.Empty)
                    {
                        mm.To.Add(LIKHAB.DataLayer.UserInfo.GetDefaulEmailOnayGeriBildirim());
                    }
                    else
                    {
                        mm.To.Add(emailisiAcan);
                    }

                    break;


                default:
                    break;
            }
        }

        static public void AddBody(string body, MailMessage mm, EmailNotificationType _type, int islemGorenSatirId, int isId = 0)
        {

            mm.Body = body;

            //switch (_type)
            //{
            //    case EmailNotificationType.RandevuOnayTalebiGonder:
            //        using (LIKHAB.Reports.Xtra_RandevuOnayTalebiEmail report = new LIKHAB.Reports.Xtra_RandevuOnayTalebiEmail())
            //        {
            //            report.Parameters["id"].Value = islemGorenSatirId;
            //            report.Parameters["isId"].Value = isId;
            //            string path = HttpContext.Current.Server.MapPath("~/body.html");
            //            report.ExportToHtml(path);
            //            mm.Body = System.IO.File.ReadAllText(path);
            //        }

            //        break;
            //    case EmailNotificationType.RandevuOnayiniGeriBildir:
            //        using (LIKHAB.Reports.Xtra_RandevuOnayGeriBildirimiEmail report = new LIKHAB.Reports.Xtra_RandevuOnayGeriBildirimiEmail())
            //        {
            //            report.Parameters["id"].Value = islemGorenSatirId;
            //            report.Parameters["isId"].Value = isId;
            //            string path = HttpContext.Current.Server.MapPath("~/body.html");
            //            report.ExportToHtml(path);
            //            mm.Body = System.IO.File.ReadAllText(path);
            //        }
            //        break;
            //    case EmailNotificationType.IsBilgileriSilimiGeriBildirimi:
            //        using (LIKHAB.Reports.Xtra_IsSilindiGeriBildirimi report = new LIKHAB.Reports.Xtra_IsSilindiGeriBildirimi())
            //        {
            //            report.Parameters["id"].Value = LIKHAB.Models.helper.Randevu.getRandevuByIsId(isId);
            //            report.Parameters["isId"].Value = isId;
            //            string path = HttpContext.Current.Server.MapPath("~/body.html");
            //            report.ExportToHtml(path);
            //            mm.Body = System.IO.File.ReadAllText(path);
            //        }

            //        break;

            //    default:
            //        break;
            //}
        }

        static public void AddSubject(MailMessage mm, EmailNotificationType _type, int islemGorenSatirId, int isId = 0)
        {
            switch (_type)
            {
                case EmailNotificationType.RandevuOnayTalebiGonder:
                    mm.Subject = "Randevu Onay Talebi";
                    break;
                case EmailNotificationType.RandevuOnayiniGeriBildir:
                    mm.Subject = "Randevu Onayi Geri Bildirimi";
                    break;
                case EmailNotificationType.IsBilgileriSilimiGeriBildirimi:
                    mm.Subject = "Is Bilgileri Silindi Geri Bildirimi";
                    break;
                default:
                    mm.Subject = "sbj";
                    break;
            }
        }
    }
}