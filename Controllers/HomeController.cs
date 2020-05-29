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
        private readonly IRubricaServices servizi;

        public HomeController(IRubricaServices serv)
        {
            servizi = serv;
        }

        public IActionResult Index()
        {
            List<ViewModelHome> contattiHome = new List<ViewModelHome>();
            contattiHome = servizi.ottieniHome();
            return View();
        }
    }
}
