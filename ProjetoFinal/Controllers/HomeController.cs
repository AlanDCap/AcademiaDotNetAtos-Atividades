using AtosProjetoFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AtosProjetoFinal.Controllers
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
            return View();
        }

        public IActionResult Start()
        {
            return RedirectToAction("Index", "Characters");
        }
        //ação usada na tela inicial para direcionar para as seções de criação de conteúdo.
        //O valor do botão é passado como string utilizada para indicar a controller alvo
        public IActionResult GoToContentCreation(string homeBtnValue)
        {
            return RedirectToAction("Index", homeBtnValue);
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