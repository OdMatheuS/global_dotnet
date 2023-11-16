using Global.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Global.Controllers
{
    public class UsuarioController : Controller
    {
        private static IList<Usuario> _listaProdutos = new List<Usuario>();
        private static int _idProduto = 0;

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

      

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
    }
}
