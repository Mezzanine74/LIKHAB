using LIKHAB.Common;
using LIKHAB.DataLayer.DBContext;
using LIKHAB.DataLayer.Models;
using System;
using System.Net.Mail;

namespace LIKHAB.Services.Email
{
    public class SendEmail
    {
        public class SmtpClient_RussianEncoded : SmtpClient
        {
            public void Send(MailMessage message)
            {
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.SubjectEncoding = System.Text.Encoding.UTF8;

                try
                {
                    // once gonder
                    base.Send(message);

                    // basariliysa database kaydet
                    string kimeString = "";
                    int i = 0;
                    foreach (var item in message.To)
                    {
                        if (i == 0)
                        {
                            kimeString += item.Address;
                        }
                        else
                        {
                            kimeString += " ," + item.Address;
                        };
                    }

                    using (var db = new LikhabDBContext())
                    {
                        var emailKAyitlari = new EmailKayitlari()
                        {
                            Kime = kimeString,
                            Body = message.Body,
                            NeZaman = LocalTime.GetIstanbul(),
                            Subject = message.Subject
                        };

                        db.EmailKayitlaris.Attach(emailKAyitlari);
                        db.EmailKayitlaris.Add(emailKAyitlari);
                        db.SaveChanges();
                    }

                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public static bool SendAway(string body, EmailNotificationType _type, int islemGorenSatirId, int isId = 0)
        {
            bool _return = false;

            MailMessage mm = new MailMessage
            {
                From = new MailAddress("savas.erzin@gmail.com", "LIKHAB"),
            };
            mm.IsBodyHtml = true;

            PrepareEmail.AddToWhom(mm, _type, islemGorenSatirId, isId);
            PrepareEmail.AddSubject(mm, _type, islemGorenSatirId, isId);
            PrepareEmail.AddBody(body, mm, _type, islemGorenSatirId, isId);

            var smtp = new SmtpClient_RussianEncoded();

            try
            {
                smtp.Send(mm);
                _return = true;
            }
            catch (Exception)
            {
                _return = false;
            }

            return _return;

        }
    }

}