using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAgenda.ViewModel;
using ProjetoAgenda.Models;

namespace ProjetoAgenda.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var usuarios = _context.Usuarios
                .Include(u => u.Telefones)
                .ToList();

            return View(usuarios);
        }

        public IActionResult CadastrarContato()
        {
            var viewModel = new CadastroCompletoViewModel
            {
                Usuario = new Usuario(),
                Endereco = new Endereco(),
                DocumentoIdentificacao = new DocumentoIdentificacao(),
                Telefone = new List<Telefone> { new Telefone() }
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarNoBanco(CadastroCompletoViewModel viewModel)
        {
            viewModel.Endereco.Situacao = "Ativo";
            Usuario usuario = viewModel.Usuario;
            viewModel.Endereco.Usuario = usuario;
            viewModel.Endereco.Situacao ??= "Ativo";
            viewModel.DocumentoIdentificacao.Usuario = usuario;
            foreach (var telefone in viewModel.Telefone)
            {
                telefone.Usuario = usuario;
                telefone.Situacao ??= "Ativo";
            }
            usuario.Endereco = viewModel.Endereco;
            usuario.DocumentoIdentificacao = viewModel.DocumentoIdentificacao;
            usuario.Telefones = viewModel.Telefone;
            ModelState.Clear();
            TryValidateModel(viewModel);

            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var estado in ModelState)
                {
                    foreach (var erro in estado.Value.Errors)
                    {
                        Console.WriteLine($"Campo com erro: {estado.Key} - Erro: {erro.ErrorMessage}");
                    }
                }
                return View("CadastrarContato", viewModel);
            }
        }

        public IActionResult ApagarContato()
        {
            return View();
        }

        //fazer esse de baixo após fazer o editar ok.
        //public IActionResult TornarInativo(int id)
        //{

        //    return View();
        //}

        [HttpGet]
        public IActionResult EditarContato(int id)
        {
            var usuario = _context.Usuarios
                .Include(u => u.Endereco)
                .Include(u => u.Telefones)
                .Include(u => u.DocumentoIdentificacao)
                .FirstOrDefault(u => u.UsuarioId == id);

            if (usuario == null)
            {
                return NotFound();
            }

            var viewModel = new CadastroCompletoViewModel
            {
                Usuario = usuario,
                Endereco = usuario.Endereco,  // Atribuindo os dados de Endereco
                Telefone = usuario.Telefones, // Atribuindo os dados de Telefone
                DocumentoIdentificacao = usuario.DocumentoIdentificacao // Atribuindo os dados de DocumentoIdentificacao
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult EditarContato(int id, CadastroCompletoViewModel viewModel)
        {
            //if (!ModelState.IsValid)
            //{
            //    foreach (var state in ModelState)
            //    {
            //        foreach (var error in state.Value.Errors)
            //        {
            //            Console.WriteLine($"Erro no campo {state.Key}: {error.ErrorMessage}");
            //        }
            //    }
            //    return View(viewModel);
            //}

            var usuarioBanco = _context.Usuarios
                .Include(u => u.Endereco)
                .Include(u => u.Telefones)
                .Include(u => u.DocumentoIdentificacao)
                .FirstOrDefault(u => u.UsuarioId == id);

            if (usuarioBanco == null)
            {
                return NotFound();
            }

            // Atualizar os dados básicos do usuário
            usuarioBanco.Nome = viewModel.Usuario.Nome;
            usuarioBanco.Email = viewModel.Usuario.Email;
            usuarioBanco.DataNascimento = viewModel.Usuario.DataNascimento;

            // Atualizar endereço, telefone e documento
            usuarioBanco.Endereco = viewModel.Endereco;
            usuarioBanco.DocumentoIdentificacao = viewModel.DocumentoIdentificacao;
            usuarioBanco.Telefones = viewModel.Telefone;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult VisualizarContato(int id)
        {
            var usuario = _context.Usuarios
                .Include(u => u.Endereco)
                .Include(u => u.DocumentoIdentificacao)
                .Include(u => u.Telefones) // <-- Certifique-se de incluir isso
                .FirstOrDefault(u => u.UsuarioId == id);

            if (usuario == null)
            {
                return NotFound();
            }

            var viewModel = new CadastroCompletoViewModel
            {
                Usuario = usuario,
                Endereco = usuario.Endereco,
                DocumentoIdentificacao = usuario.DocumentoIdentificacao,
                Telefone = usuario.Telefones
            };

            return View(viewModel);
        }
    }
}