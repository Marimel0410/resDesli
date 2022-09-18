using Microsoft.AspNetCore.Mvc;
using resDesli.Models;
using System.Diagnostics;

namespace resDesli.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["midato"] = "Aqui encontraras todo acerca de nosotros";
            return View();
        }

        public IActionResult Privacy()
        {

            ViewBag.Misegundodato = "Completa los campos y confirma tu reserva";
            return View();
        }
        public IActionResult Menu()
        {

            var PlatosDelMenu = new PlatosDelMenu();
            var model = PlatosDelMenu.ObtenerPlatos();
            ViewBag.Mensaje = "Estamos mejorando para tí. Disfruta los platos de nuestro menú provicional";

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}