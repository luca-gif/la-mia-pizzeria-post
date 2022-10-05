namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
      /*  public Pizza(int id, string name, string description, string image, double price)
        {
            PizzaId = id;
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }*/

        public int PizzaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }

    }
}
