using Global.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Global.Controllers
{
    public class DadosSuplementaresUsrController : Controller
    {
        private ClasseContext _context;

        public DadosSuplementaresUsrController(ClasseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(DadosSuplementaresUsr dadosSup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dadosSup);
                _context.SaveChanges();
                TempData["msg"] = "Dados Suplementares cadastrado com sucesso!";
                return RedirectToAction("Listar");
            }
            else
            {
                return View(dadosSup);
            }
        }


        public IActionResult Listar()
        {
            var dadosSup = _context.DadosSuplementaresUsrs.ToList();
            return View(dadosSup);
        }


        [HttpPost]
        public IActionResult Excluir(int id)
        {

            var dadosSup = _context.DadosSuplementaresUsrs.Find(id);


            if (dadosSup != null)
            {
                _context.Remove(dadosSup);
                _context.SaveChanges();
                TempData["msg"] = "Dados Suplementares removido com sucesso!";
            }
            else
            {
                TempData["msg"] = "Dados Suplementares não encontrado.";
            }

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var dadosSup = _context.DadosSuplementaresUsrs.Find(id);
            _context.DadosSuplementaresUsrs.Update(dadosSup);
            _context.SaveChanges();
            if (dadosSup == null)
            {
                TempData["msg"] = "Dados Suplementares não encontrado.";
                return RedirectToAction("Listar");
            }

            return View(dadosSup);
        }

        [HttpPost]
        public IActionResult Editar(DadosSuplementaresUsr dadosSup)

        {
         
            string a = HttpContext.Request.Path.ToString();
            int id = int.TryParse(a.Split('/').LastOrDefault(), out int temp) ? temp : default;
            var dadosSupExistente = _context.DadosSuplementaresUsrs.Find(id);

            if (dadosSupExistente != null)
            {
                
                    dadosSupExistente.Idade = dadosSup.Idade;
                    dadosSupExistente.Peso = dadosSup.Peso;
                    dadosSupExistente.Altura = dadosSup.Altura;
                    dadosSupExistente.Sexo = dadosSup.Sexo;
                    _context.SaveChanges();

                    TempData["msg"] = "Dados Suplementares atualizado com sucesso!";
                }
            else
            {
                TempData["msg"] = "Dados Suplementares não encontrado.";
            }

            return RedirectToAction("Listar");
        }
      
    }
}
