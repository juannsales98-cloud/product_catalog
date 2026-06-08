using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeuProjeto.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            
            List<string> nomes = new List<string>()
            {
                "Teclado Mecânico",
                "Mouse Pad Gamer",
                "Monitor 24'",
                "Cabo HDMI",
                "Fone de Ouvido"
            };

            
            List<double> precos = new List<double>()
            {
                350.00,
                89.90,
                899.00,
                25.50,
                120.00
            };

            
            ViewBag.ListaNomes = nomes;
            ViewBag.ListaPrecos = precos;

            return View();
        }
    }
}