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
        private readonly RubricaDBContext _db;

        public HomeController(ILogger<HomeController> logger, RubricaDBContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            Contatto contatto = new Contatto();
           
            contatto.nome = "Egmonte";
            _db.contatti.Add(contatto);

            _db.SaveChanges();
            
            return View(contatto);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}