using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AgendadorVacina.Controllers
{
    public class AgendadorVacinaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Método de teste
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}