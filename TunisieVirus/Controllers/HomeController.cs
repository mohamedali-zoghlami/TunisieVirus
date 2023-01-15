using Microsoft.AspNetCore.Mvc;

using TunisieVirus.Data.Context;
using TunisieVirus.Data.Repository;
using TunisieVirus.Models;

namespace TunisieVirus.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            var repository = new VirusCounterRepository(ApplicationContext.Instance);
            var virus = repository.GetAll();
            return View(virus);
        }   
        [HttpPost]
        [Route("/HomeController/{route}")]
        public IActionResult Summary(String name)
        { 
            var repository=new VirusCounterRepository(ApplicationContext.Instance);

            var virus = repository.Get(name);
            ViewBag.name = name;
            ViewBag.description = virus.description;
            ViewBag.NewRecovered = virus.NewRecovred;
            ViewBag.NewDeaths = virus.NewDeath;
            ViewBag.NewConfirmed= virus.NewConfirmed;
            ViewBag.TotalRecovered = virus.TotalRecovred;
            ViewBag.TotalDeaths = virus.TotalDeath;
            ViewBag.TotalConfirmed = virus.TotalConfirmed;
            ViewBag.Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-1));
            return View();
        }

        
    }
}