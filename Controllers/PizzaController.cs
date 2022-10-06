using la_mia_pizzeria_static.Context;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            using (Restaurant db = new Restaurant())
            {
                
                List<Pizza> pizzas = db.ListaPizze.OrderBy(pizza => pizza.PizzaId).ToList<Pizza>();

                return View("Index", pizzas);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Pizza data)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
         
            using(Restaurant db = new Restaurant())
            {
                Pizza newPizza = new Pizza(); //istanzio una nuova pizza
                newPizza.Name = data.Name;
                newPizza.Image = data.Image;
                newPizza.Description = data.Description;
                newPizza.Price = data.Price;

                db.ListaPizze.Add(newPizza);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


         public IActionResult Detail(int id)
          {
            Restaurant db = new Restaurant();

            Pizza PizzaDetail = db.ListaPizze.Where(p => p.PizzaId == id).FirstOrDefault();

            return View(PizzaDetail);
          }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}