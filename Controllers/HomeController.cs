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
    [ApiController]
    [Route("/api/Home")]
    public class HomeController : ControllerBase
    {
        private readonly RubricaDBContext _db;

        public HomeController(RubricaDBContext db)
        {
            _db = db;
        }

        //Ritorna un Json di tutti i dati del database ordinati per "Cognome"
        [HttpGet]
        public ActionResult Index()
        {
            ////Crea un contatto di nome "Egmonte" 
            //Contatto contatto = new Contatto();
            //contatto.nome = "Egmonte";
            //_db.contatti.Add(contatto);
            //_db.SaveChanges();

            List<Contatto> contatti = new List<Contatto>();
            foreach (Contatto c in _db.contatti
                       .OrderBy(x => x.cognome))
            {
                contatti.Add(c);
            }
            
            return Ok(contatti);
        }
    }
}