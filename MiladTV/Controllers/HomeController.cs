using Microsoft.AspNetCore.Mvc;
using MiladTV.Models;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace MiladTV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        public async Task<IActionResult> SendMessage(string Name, string Email, string Message)
        {
            var fromAddress = new MailAddress("milad111220066@gmail.com");
            var toAddress = new MailAddress("milad111220066@gmail.com");

            const string fromPassword = "otro alnz uael hbtl"; // IMPORTANT

            string subject = "Zpráva z webu MiladTV";
            string body = $"Jméno: {Name}\nEmail: {Email}\n\nZpráva:\n{Message}";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                await smtp.SendMailAsync(message);
            }

            return RedirectToAction("Contact");


        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult References()
        {
            return View();
        }

        public IActionResult Skills()
        {
            return View();
        }
       

    }
}
