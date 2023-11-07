using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace NFDao.Tools
{
    public class EmailManager
    {
        private string mail = "beerzonmanager@gmail.com";
        private string password = "jxfvnfrwdcwqiddr";
        private string to { get; set; }
        private string body { get; set; }

        public EmailManager(string to)
        {
            this.to = to;
        }
        public bool RecoverAcount(string newPassword)
        {
            using (MailMessage email = new MailMessage())
            {
                email.From = new MailAddress(mail);
                email.To.Add(new MailAddress(to));
                email.Subject = "Recuperacion de credenciales";
                email.IsBodyHtml = true;
                string html = @"<!DOCTYPE html>
                                <html>
                                <head>
                                    <style>
                                        body {
                                            font-family: Arial, sans-serif;
                                            background-color: #f0f0f0;
                                            text-align: center;
                                        }
                                        .container {
                                            background-color: #ffffff;
                                            padding: 20px;
                                            border-radius: 10px;
                                            width: 80%;
                                            max-width: 400px;
                                            margin: 0 auto;
                                        }
                                        h1 {
                                            color: #009900;
                                        }
                                        p {
                                            color: #333333;
                                        }
                                        a {
                                            text-decoration: none;
                                            color: #009900;
                                        }
                                    </style>
                                </head>
                                <body>
                                    <div class=""container"">
                                        <h1>Restablecer Contraseña en Narices Frías</h1>
                                        <p>Hola,</p>
                                        <p>Haz hemos restablecido tu contraseña:</p>
                                        <p>usa esta contraseña temporal y cambiala al iniciar sesion : {{temp}}  </p>
                                        <p>Si no solicitaste un restablecimiento de contraseña, puedes ignorar este correo.</p>
                                    </div>
                                </body>
                                </html>";
                html = html.Replace("{{temp}}", newPassword);
                email.Body = html;

                using (System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;

                    smtpClient.Credentials = new NetworkCredential(mail, password);

                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                    try
                    {
                        smtpClient.Send(email);
                        return true;
                    }
                    catch (SmtpException ex)
                    {
                        // Manejo de errores específicos de SMTP
                        Console.WriteLine("Error SMTP al enviar el correo: " + ex.Message);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        // Otros errores
                        Console.WriteLine("Error al enviar el correo: " + ex.Message);
                        return false;
                    }
                }
            }
            
        }
    }
}
