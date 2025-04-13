using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoAgenda.Models;

namespace ProjetoAgenda.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Index()
    {
        var usuarios = _context.Usuarios.ToList();
        return View(usuarios);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
