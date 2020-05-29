using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlayGround_Dependency_Injection.Models;

namespace PlayGround_Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Contatto contatto = new Contatto();
            using (var _context = new RubricaDBContext())
            {
                contatto.nome = "Egmonte";

                _context.contatti.Add(contatto);

                _context.SaveChanges();
            }
            return View(contatto);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}