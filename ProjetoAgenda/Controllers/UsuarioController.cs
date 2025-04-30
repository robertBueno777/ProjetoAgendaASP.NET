using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAgenda.ViewModel;
using ProjetoAgenda.Models;
using System.Drawing.Printing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoAgenda.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ApagarContato(int id)
        {
            var usuario = _context.Usuarios
                .Include(u => u.Endereco)
                .Include(u => u.Telefones)
                .Include(u => u.DocumentoIdentificacao)
                .SingleOrDefault(u => u.UsuarioId == id);

            if (usuario == null)
                return NoContent();

            return View(usuario);
        }

        public IActionResult Index()
        {
            var usuariosAtivos = _context.Usuarios
                //.Include(u => u.Telefones.Where(x => x.Situacao.Equals("Ativo")))

                .Include(u => u.Telefones)
                //.Include(u => u.Telefones)
                .Where(u => u.Endereco.Situacao == "Ativo")
                .ToList();

            //foreach (var u in usuariosAtivos)
            //    u.Telefones = u.Telefones.Where(x => x.Situacao.Equals("Ativo")).ToList();

            return View(usuariosAtivos);
        }
        [HttpPost]
        public IActionResult ApagarCelular(int id)
        {
            var telefoneRemove = _context.Telefones.FirstOrDefault(u => u.TelefoneId == id);
            if (telefoneRemove == null)
            {
                return NotFound();
            }

            _context.Telefones.Remove(telefoneRemove);
        

            _context.SaveChanges();

            return RedirectToAction("Index");



        }


        [HttpGet]
        public IActionResult AdicionarCelular(int id)
        {
            var usuario = _context.Usuarios
                .Include(u => u.Telefones)
                .FirstOrDefault(u => u.UsuarioId == id);

            if (usuario == null)
                return NotFound();

            var viewModel = new CadastroCompletoViewModel
            {
                Usuario = usuario,
                Telefone = new List<Telefone> { new Telefone() }
            };

            ViewBag.TelefonesAntigos = usuario.Telefones;
            return View("AdicionarCelular", viewModel);
        }

        [HttpPost]
        public IActionResult AdicionarContato(CadastroCompletoViewModel model)
        {
            foreach (var estado in ModelState)
            {
                foreach (var erro in estado.Value.Errors)
                {
                    Console.WriteLine($"Campo com erro: {estado.Key} - Erro: {erro.ErrorMessage}");
                    ViewBag.TelefonesAntigos = _context.Telefones
                              .Where(t => t.UsuarioId == model.Usuario.UsuarioId)
                              .ToList();
                }
            }

            var usuario = _context.Usuarios
                .Include(u => u.Telefones)
                .FirstOrDefault(u => u.UsuarioId == model.Usuario.UsuarioId);

            if (usuario == null)
            {
                return NotFound();
            }

            //foreach (var tel in usuario.Telefones)
            //{
            //    tel.Situacao = "Inativa";
            //}

            var novoTel = model.Telefone.FirstOrDefault();
            if (novoTel != null)
            {
                novoTel.Situacao = "Ativo";
                novoTel.UsuarioId = usuario.UsuarioId;
                _context.Telefones.Add(novoTel);
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public IActionResult FazerInativo(int id)
        //{
        //    var usuario = _context.Usuarios
        //        .Include(u => u.Telefones)              
        //        .SingleOrDefault(u => u.UsuarioId == id);

        //    if (usuario == null)
        //        return NoContent();

        //    return View(usuario);
        //}


        [HttpPost]
        public IActionResult TornarAtivo(int id)
        {
            var telefone = _context.Telefones.FirstOrDefault(u => u.TelefoneId == id);
            if (telefone == null)
            {
                return NotFound();
            }
            telefone.Situacao = "Ativo";

            _context.SaveChanges();

            return RedirectToAction("Index");


        }




        [HttpPost]
        public IActionResult TornarInativo(int id)
        {
            var telefone = _context.Telefones.FirstOrDefault(u => u.TelefoneId == id);
            if (telefone == null)
            {
                return NotFound();
            }
            telefone.Situacao = "Inativo";

            _context.SaveChanges();

            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult CadastrarContato(int? estadoSelecionadoId)
        {
            var estados = new EstadoCidade().GetEstados();

            var viewModel = new CadastroCompletoViewModel
            {
                Usuario = new Usuario(),
                Endereco = new Endereco(),
                DocumentoIdentificacao = new DocumentoIdentificacao(),
                Telefone = new List<Telefone> { new Telefone() },
                Ufs = estados,
                EstadoSelecionadoId = estadoSelecionadoId,
                Cidades = new List<Cidade>()
            };

            if(estadoSelecionadoId.HasValue)
            {
                var estado = estados.FirstOrDefault(e => e.EstadoId == estadoSelecionadoId.Value);
                if (estado != null)
                    viewModel.Cidades = estado.Cidades;

            }

            return View(viewModel);
       
        }

        //[HttpGet]
        //public IActionResult CadastrarContato()
        //{
        //    var viewModel = new CadastroCompletoViewModel
        //    {
        //        Usuario = new Usuario(),
        //        Endereco = new Endereco(),
        //        DocumentoIdentificacao = new DocumentoIdentificacao(),
        //        Telefone = new List<Telefone> { new Telefone() },
        //        Ufs = new EstadoCidade().GetEstados(),

        //    };
        //    return View(viewModel);
        //}

        [HttpPost]
        public async Task<IActionResult> CadastrarNoBanco(CadastroCompletoViewModel viewModel)
        {
            //viewModel.Ufs = new EstadoCidade().GetEstados();
            //if(viewModel.EstadoSelecionadoId.HasValue)
            //{
            //    var estadoSelecionado =  
            //}



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
                return RedirectToAction("Index", "Usuario");
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

        //public IActionResult ApagarContato()
        //{
        //    var usuarios = _context.Usuarios.ToList();
        //    return View(usuarios);
        //}

        [HttpGet]
        public IActionResult ConfirmarInativacao(int id)
        {
            var usuario = _context.Usuarios
                .Include(u => u.Endereco)
                .FirstOrDefault(u => u.UsuarioId == id);


            if (usuario == null)
            {
                return NotFound();
            }


            usuario.Endereco.Situacao = "Inativo";

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult VisualizarContato(int id)
        {
            var usuario = _context.Usuarios
                .Include(u => u.Endereco)
                .Include(u => u.DocumentoIdentificacao)
                .Include(u => u.Telefones)
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
                Endereco = usuario.Endereco,
                Telefone = usuario.Telefones,
                DocumentoIdentificacao = usuario.DocumentoIdentificacao
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

            usuarioBanco.Nome = viewModel.Usuario.Nome;
            usuarioBanco.Email = viewModel.Usuario.Email;
            usuarioBanco.DataNascimento = viewModel.Usuario.DataNascimento;

            usuarioBanco.Endereco = viewModel.Endereco;
            //usuarioBanco.DocumentoIdentificacao = viewModel.DocumentoIdentificacao;
            //usuarioBanco.Telefones = viewModel.Telefone;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}