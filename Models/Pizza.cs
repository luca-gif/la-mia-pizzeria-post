﻿namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public Pizza()
        {

        }

        public int PizzaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }

    }
}
