using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AgendadorVacina.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}