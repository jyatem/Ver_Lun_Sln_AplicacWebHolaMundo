using AplicacWebHolaMundo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacWebHolaMundo.Controllers
{
    public class SaludoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Persona persona)
        {
            return View("Resultado", persona);
        }
    }
}
