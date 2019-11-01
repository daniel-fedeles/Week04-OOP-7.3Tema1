using System.Collections.Generic;

namespace week4_oop_Ex5
{
    public class Pizza
    {
        public Pizza(PizzaBase pizzaBase)
        {
            this.PizzaBase = pizzaBase;
        }

        public string Name { get; set; }
        public PizzaBase PizzaBase { get; set; }
        public List<PizzaTopping> PizzaToppings { get; set; }

        public void AddTopping() { }
        public void CalculateTotalCost() { }

    }
}
