using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninove.Web.Models;

namespace Uninove.Web.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Vitoria Costa";
        ViewBag.Curso = "Análise de Sistemas";
        ViewBag.Semestre = 1;

        return View();
    }
}
