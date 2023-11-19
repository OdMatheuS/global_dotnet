using Global.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Global.Controllers
{
    public class UsuarioController : Controller
    {
        private static IList<Usuario> _listaUsuarios = new List<Usuario>();
        private static int _idProduto = 0;

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            usuario.Id = ++_idProduto;
            _listaUsuarios.Add(usuario);
            TempData["msg"] = "Usuário cadastrado com sucesso!";
            return RedirectToAction("Listar");
        }

        public IActionResult Listar()
        {
            return View(_listaUsuarios);
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var usuario = _listaUsuarios.FirstOrDefault(p => p.Id == id);
            if (usuario != null)
            {
                _listaUsuarios.Remove(usuario);
                TempData["msg"] = "Usuário removido com sucesso!";
            }
            else
            {
                TempData["msg"] = "Usuário não encontrado.";
            }

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var usuario = _listaUsuarios.FirstOrDefault(p => p.Id == id);
            if (usuario == null)
            {
                TempData["msg"] = "Usuário não encontrado.";
                return RedirectToAction("Listar");
            }

            return View(usuario);
        }

        [HttpPost]
        public IActionResult Editar(Usuario usuario)
        {
            var usuarioExistente = _listaUsuarios.FirstOrDefault(p => p.Id == usuario.Id);
            if (usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Idade = usuario.Idade;
                TempData["msg"] = "Usuário atualizado com sucesso!";
            }
            else
            {
                TempData["msg"] = "Usuário não encontrado.";
            }

            return RedirectToAction("Listar");
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
