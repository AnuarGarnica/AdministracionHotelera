using AdministracionHoteles.Models;
using AdministracionHoteles.Tools.Services;
using AdministracionHoteles.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdministracionHoteles.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContextLPL _dbContext;
        private readonly IEmailSender _emailsender;

        public HomeController(ILogger<HomeController> logger, DataContextLPL dataContext, IEmailSender emailSender)
        {
            _logger = logger;
            _dbContext = dataContext;
            _emailsender = emailSender;
        }


        public IActionResult Index()
        {
            var hoteles = _dbContext.Hoteles.Where(c => c.Estatus == true);
           // _emailsender.SendEmailAsync("agarnicam1200@alumno.ipn.mx", "Este es un correo", "Este es el mensaje del correo");
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
    }
}