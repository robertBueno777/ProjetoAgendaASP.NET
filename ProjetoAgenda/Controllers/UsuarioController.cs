using Microsoft.AspNetCore.Mvc;
using ProjetoAgenda.Models;
using System.Data.Entity;

namespace ProjetoAgenda.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult CadastrarContato()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> CadastrarNoBanco(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Feitiço de revelação: log dos erros de validação
                foreach (var estado in ModelState)
                {
                    foreach (var erro in estado.Value.Errors)
                    {
                        Console.WriteLine($"🛑 Campo com erro: {estado.Key} - Erro: {erro.ErrorMessage}");
                    }
                }

                return View("CadastrarContato", usuario);
            }
        }



    }
}
