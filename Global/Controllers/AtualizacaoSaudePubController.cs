using Global.Models;
using Microsoft.AspNetCore.Mvc;

public class AtualizacaoSaudePubController : Controller
{
    private readonly ClasseContext _context;

    public AtualizacaoSaudePubController(ClasseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        var novaAtualizacao = new AtualizacaoSaudePub();
        return View(novaAtualizacao);
    }


    [HttpPost]
    public IActionResult Cadastrar(AtualizacaoSaudePub atualizacaoSaudePub)
    {
        if (ModelState.IsValid)
        {
            _context.Add(atualizacaoSaudePub);
            _context.SaveChanges();
            TempData["msg"] = "Atualização de Saúde Pública cadastrada com sucesso!";
            return RedirectToAction("Listar");
        }
        else
        {
            return View(atualizacaoSaudePub);
        }
    }

    [HttpGet]
    public IActionResult Listar()
    {
        var listaAtualizacoes = _context.AtualizacaoSaudePubs.ToList();
        return View(listaAtualizacoes);
    }

    [HttpGet]
    public IActionResult Editar(int id)
    {
        var atualizacaoSaudePub = _context.AtualizacaoSaudePubs.Find(id);

        if (atualizacaoSaudePub == null)
        {
            TempData["msg"] = "Atualização de Saúde Pública não encontrada.";
            return RedirectToAction("Listar");
        }

        return View(atualizacaoSaudePub);
    }

    [HttpPost]
    public IActionResult Editar(AtualizacaoSaudePub atualizacaoSaudePub)
    {
        if (ModelState.IsValid)
        {
            _context.Update(atualizacaoSaudePub);
            _context.SaveChanges();
            TempData["msg"] = "Atualização de Saúde Pública atualizada com sucesso!";
            return RedirectToAction("Listar");
        }
        else
        {
            return View(atualizacaoSaudePub);
        }
    }

    [HttpPost]
    public IActionResult Excluir(int id)
    {
        var atualizacaoSaudePub = _context.AtualizacaoSaudePubs.Find(id);

        if (atualizacaoSaudePub != null)
        {
            _context.Remove(atualizacaoSaudePub);
            _context.SaveChanges();
            TempData["msg"] = "Atualização de Saúde Pública removida com sucesso!";
        }
        else
        {
            TempData["msg"] = "Atualização de Saúde Pública não encontrada.";
        }

        return RedirectToAction("Listar");
    }

    [HttpGet]
    public IActionResult BuscarPorNomeCampanha(string valor)
    {
        var lista = _context.AtualizacaoSaudePubs.Where(f => f.Titulo.Contains(valor)).ToList();
        return View("Listar", lista);
    }
}
