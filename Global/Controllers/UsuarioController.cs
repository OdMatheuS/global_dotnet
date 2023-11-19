using Global.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Global.Controllers
{
    public class UsuarioController : Controller
    {
        private ClasseContext _context;

        public UsuarioController(ClasseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                _context.SaveChanges();
                TempData["msg"] = "Usuário cadastrado com sucesso!";
                return RedirectToAction("Listar");
            }
            else
            {
                return View(usuario);
            }
        }


        public IActionResult Listar()
        {
            var usuarios = _context.Usuarios.ToList();
            return View(usuarios);
        }


        [HttpPost]
        public IActionResult Excluir(int id)
        {

            var usuario = _context.Usuarios.Find(id);


            if (usuario != null)
            {
                _context.Remove(usuario);
                _context.SaveChanges();
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
            var usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
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
            var usuarioExistente = _context.Usuarios.Find(usuario.Id);

            if (usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Idade = usuario.Idade;
                usuarioExistente.Peso = usuario.Peso;
                usuarioExistente.Altura = usuario.Altura;
                usuarioExistente.TempoSono = usuario.TempoSono;
                usuarioExistente.PraticaEsporte = usuario.PraticaEsporte;

                _context.SaveChanges();

                TempData["msg"] = "Usuário atualizado com sucesso!";
            }
            else
            {
                TempData["msg"] = "Usuário não encontrado.";
            }

            return RedirectToAction("Listar");
        }


        [HttpGet]
        public IActionResult BuscarPorNome(string valor)
        {
            var lista = _context.Usuarios.Where(f => f.Nome.Contains(valor)).ToList();
            return View("Listar", lista);
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
