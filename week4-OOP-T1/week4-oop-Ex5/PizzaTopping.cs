using System;
using System.ComponentModel;

namespace week4_oop_Ex5
{
    public enum Topping
    {
        [Description("Cheese")]
        Cheese,
        [Description("Meat")]
        Meat,
        [Description("Vegetable")]
        Vegetable,


    }
    public class PizzaTopping
    {
        public string Name { get; set; }

        public void Cost(Enum topping)
        {
            int sum = 0;
            if (Topping.Cheese.ToString() == "Cheese")
            {

            }
        }
        public void Print() { }
    }
}
