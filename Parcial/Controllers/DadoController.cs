using Microsoft.AspNetCore.Mvc;
using Parcial.Models;

namespace Parcial.Controllers
{
    public class DadoController : Controller
    {
        public IActionResult Index()
        {
            var dado = new Dado();
            int resultado = dado.Lanzar();
            ViewBag.Resultado = resultado;
            return View();
        }
    }
}
