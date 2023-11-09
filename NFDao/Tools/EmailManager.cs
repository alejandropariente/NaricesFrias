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
using NFDao.Model;

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
        public bool AcceptedDate(SystemUser user,AnimalDate date)
        {
            using (MailMessage email = new MailMessage())
            {
                email.From = new MailAddress(mail);
                email.To.Add(new MailAddress(to));
                email.Subject = "Credenciales NF";
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
                                        <h1>Bienvenido a Narices Frías</h1>
                                        <p>Hola, {{UserName}} </p>
                                        <p>Tu cita para el dia {{dayOfWeek}} : {{date}} , a las : {{dateTime}} </p>
                                        <p>Ha sido Aceptada!</p>
                                        <p>Te esperamos la fecha y hora acordada!</p>
                                        <p>Si no has reservado una cita en Narices Frías, por favor ignora este mensaje.</p>
                                    </div>
                                </body>

                                </html>
                                ";
                html = html.Replace("{{UserName}}", user.userName)
                    .Replace("{{date}}", date.date.Date.ToString("yyyy/MM/dd"))
                    .Replace("{{dateTime}}", date.date.Hour.ToString()+":"+date.date.Minute)
                    .Replace("{{dayOfWeek}}", TranslateDay(date.date.DayOfWeek.ToString()));
                email.Body = html;

                return SendEmail(email);
            }

        }
        static string TranslateDay(string diaEnIngles)
        {
            // Diccionario de traducción
            Dictionary<string, string> traducciones = new Dictionary<string, string>
        {
            { "Monday", "Lunes" },
            { "Tuesday", "Martes" },
            { "Wednesday", "Miércoles" },
            { "Thursday", "Jueves" },
            { "Friday", "Viernes" },
            { "Saturday", "Sábado" },
            { "Sunday", "Domingo" }
        };

            // Verificar si el día está en el diccionario y realizar la traducción
            if (traducciones.ContainsKey(diaEnIngles))
            {
                return traducciones[diaEnIngles];
            }
            else
            {
                return "Día no reconocido";
            }
        }
        public bool RejectedDate(SystemUser user, AnimalDate date)
        {
            using (MailMessage email = new MailMessage())
            {
                email.From = new MailAddress(mail);
                email.To.Add(new MailAddress(to));
                email.Subject = "Credenciales NF";
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
                                        <h1>Bienvenido a Narices Frías</h1>
                                        <p>Hola, {{UserName}} </p>
                                        <p>Tu cita para el dia {{dayOfWeek}} : {{date}} , a las : {{dateTime}} </p>
                                        <p>Ha sido rechazada</p>
                                        <p>Prueba a reservar otra cita o contactarse con el refugio</p>
                                        <p>Si no has reservado una cita en Narices Frías, por favor ignora este mensaje.</p>
                                    </div>
                                </body>

                                </html>
                                ";
                html = html.Replace("{{UserName}}", user.userName)
                    .Replace("{{date}}", date.date.Date.ToString("yyyy/MM/dd"))
                    .Replace("{{dateTime}}", date.date.Hour.ToString() + ":" + date.date.Minute)
                    .Replace("{{dayOfWeek}}", TranslateDay(date.date.DayOfWeek.ToString()));
                email.Body = html;

                return SendEmail(email);
            }

        }
        public bool SenCredentials(SystemUser user)
        {
            using (MailMessage email = new MailMessage())
            {
                email.From = new MailAddress(mail);
                email.To.Add(new MailAddress(to));
                email.Subject = "Credenciales NF";
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
                                        <h1>Bienvenido a Narices Frías</h1>
                                        <p>Hola, {{UserName}} </p>
                                        <p>Te hemos creado una cuenta en Narices Frías y aquí está tu contraseña temporal:</p>
                                        <p>{{temp}}</p>
                                        <p>Correo : {{email}}</p>
                                        <p>Por favor, inicia sesión con esta contraseña temporal y recuerda cambiarla por una nueva contraseña segura tan pronto como inicies sesión. Esta contraseña temporal es para tu primera sesión.</p>
                                        <p>Si no has creado una cuenta en Narices Frías, por favor ignora este mensaje.</p>
                                    </div>
                                </body>

                                </html>
                                ";
                html = html.Replace("{{temp}}", user.password).Replace("{{UserName}}", user.userName).Replace("{{email}}", user.email);
                email.Body = html;

                return SendEmail(email);
            }

        }
        private bool SendEmail(MailMessage email)
        {
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

                return SendEmail(email);
            }
            
        }
    }
}
