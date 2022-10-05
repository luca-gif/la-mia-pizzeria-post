using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
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

            return View(Pizzas());
        }

        public IActionResult Detail(int id)
        {
            
            return View(Pizzas()[id]);
        }

        public List<Pizza> Pizzas()
        {
            List<Pizza> pizze = new List<Pizza> {

                new Pizza(0, "Margherita", "Pomodoro, Mozzarella", "/img/pizza-margherita.jpg", 5),
                new Pizza(1, "Diavola", "Pomodoro, Mozzarella, salame piccante", "/img/pizza-diavola.jpg", 7),
                new Pizza(2, "Marinara", "Pomodoro", "/img/pizza-marinara.jpg", 4),
                new Pizza(3, "Salsiccia", "Pomodoro, Mozzarella, salsiccia", "/img/pizza-salsiccia.jpg", 7),

            };

            return pizze;
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