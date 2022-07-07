using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string nome, int vezes = 1, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Oi, {nome}, vezes: {vezes}. ID: {ID}") ;
        }
    }
}
