using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace ProjetoBar
{
    class SendEmail
    {

        public static void enviaremail()
        {
            string Date = DateTime.Now.ToString("dd/MM/yyyy");

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(ALLVARS.email1)
            };
            mailMessage.To.Add(new MailAddress(ALLVARS.email2));

            //Cópia:
            //mailMessage.CC.Add(new System.Net.Mail.MailAddress("copia@email.com"));

            //Cópia oculta:
            //mailMessage.Bcc.Add(new System.Net.Mail.MailAddress("copia.oculta@email.com"));

            mailMessage.Subject = "Restaurant Bar - Pedido mesa: | "+ ArquivoTXT.mesa + " | Cliente: " + ArquivoTXT.nome;
            mailMessage.Body = "O Restaurant Bar agradece pela sua preferência" +
                                "\n" +
                 ALLVARS.mensagem;


            mailMessage.IsBodyHtml = false;

            using (var smtp = new SmtpClient())
            { 
                try
                {
                smtp.Host = "smtp.mail.yahoo.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential(ALLVARS.email1, ALLVARS.senha);

                //Exemplo de anexo de texto:
                //mailMessage.Attachments.Add(new System.Net.Mail.Attachment(
                //   new MemoryStream(Encoding.UTF8.GetBytes("conteudo do arquivo")),
                //   "anexo.txt", System.Net.Mime.MediaTypeNames.Text.Plain));
               
                    smtp.Send(mailMessage);
                    MessageBox.Show("E-mail enviado com sucesso!!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
