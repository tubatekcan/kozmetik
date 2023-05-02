using System;
using System.Text;

namespace kozmetik.Helpers
{
    public class EpostaIslemleri
    {

        public static  void AktivasyonMailiGonder(string alici)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(alici);
            mail.From = new System.Net.Mail.MailAddress("mailaktiveet@gmail.com");
            mail.Subject = "heryemek.com Kullanıcı Aktivasyon";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;

            string linkk = "https://www.heryemek.com/hesap/aktivasyon?kkk=" + Sifreleme.Sifrele(alici);


            var HtmlBody = new StringBuilder();
            HtmlBody.AppendFormat("Hoşgeldiniz, Sevgili Kullanıcımız");
            HtmlBody.AppendLine(@"Hesabınızı aktive etmek için aşağıdaki bağlantıya tıklayın.");
            HtmlBody.AppendLine("<a href=\""+linkk+"\">AKTİVASYON</a>");
            mail.Body = HtmlBody.ToString();
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = System.Net.Mail.MailPriority.Normal;
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();


            client.Credentials = new System.Net.NetworkCredential("mailaktiveet@gmail.com", "miqbnjgmdujltwxb");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            
            try
            {
                client.Send(mail);

            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }

            }
        }


        public static void SifremiYenileMailiGonder(string alici)
        {

            string linkk = "http://www.zodyakcta.com/Hesap/SifremiUnuttumDegistir?yyy=" + Sifreleme.Sifrele(alici);


            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(alici);
            mail.From = new System.Net.Mail.MailAddress("info@zodyakcta.com");
            mail.Subject = "Zodyak Market Şifremi Yenile";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            var HtmlBody = new StringBuilder();
            HtmlBody.AppendFormat("Hoşgeldiniz , {0}\n", "Sevgili Kullanıcımız");
            HtmlBody.AppendLine(@"Şifrenizi yenilemek için ") ;
            HtmlBody.AppendLine("<a href=\"" + linkk + "\">BURAYA BASINIZ.</a>");
            mail.Body = HtmlBody.ToString();
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = System.Net.Mail.MailPriority.High;
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();


            client.Credentials = new System.Net.NetworkCredential("info@zodyakcta.com", "Sifre1717!");
            client.Port = 3535;
            client.Host = "smtpout.secureserver.net";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);

            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }

            }
        }
    }
}
