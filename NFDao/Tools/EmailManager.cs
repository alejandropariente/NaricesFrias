using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Text;
using System.Threading.Tasks;

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
            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Beerzon Oficial", this.mail));
                message.To.Add(new MailboxAddress("", this.to));
                message.Subject = "Credenciales";

                var builder = new BodyBuilder();
                string html = @"<!DOCTYPE html>
                                    <html>

                                    <head>
                                      <title>Bienvenido a Beerzon</title>
                                      <style>
                                        body {
                                          font-family: Arial, sans-serif;
                                          margin: 0;
                                          padding: 0;
                                        }

                                        .container {
                                          background-color: #222121;
                                          padding: 40px;
                                          color: white;
                                          width: 400px;
                                          margin: 0 auto;
                                        }

                                        h1 {
                                          margin-bottom: 20px;
                                          font-size: 24px;
                                        }

                                        p {
                                          margin-bottom: 10px;
                                          font-size: 16px;
                                        }

                                        ul {
                                          margin-top: 10px;
                                          margin-bottom: 20px;
                                          list-style-type: none;
                                          padding: 0;
                                        }

                                        li {
                                          margin-bottom: 5px;
                                        }

                                        strong {
                                          font-weight: bold;
                                        }

                                        .username {
                                          color: #5c0a15;
                                        }

                                        .footer {
                                          font-size: 14px;
                                          text-align: center;
                                        }
                                        .header {
                                          background-color: #5c0a15;
                                          padding: 20px;
                                          text-align: center;
                                        }
                                      </style>
                                    </head>

                                    <body>
                                        
                                      <div class=""container"" style=""color: white;"">
                                        <h1>¡Bienvenido a Beerzon!</h1>
                                        <p>Estimado empleado,</p>
                                        <p>Tu cuenta ha sido creada en Beerzon, la licorería más destacada. A continuación, encontrarás tus credenciales de inicio de sesión:</p>
                                        <ul>
                                          <li><strong>Usuario:</strong> <span class=""username"">[{username}]</span></li>
                                          <li><strong>Contraseña:</strong> <span class=""username"">[{pass}]</span></li>
                                        </ul>
                                        <p>Te recomendamos cambiar tu contraseña después de iniciar sesión por primera vez.</p>
                                        <p>¡Esperamos que disfrutes trabajar con nosotros!</p>
                                        <p class=""footer"">Atentamente,<br>Equipo de Beerzon</p>
                                      </div>
                                    </body>

                                    </html>";
                builder.HtmlBody = html;
                message.Body = builder.ToMessageBody();

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate(this.mail, this.password);
                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
    }
}
