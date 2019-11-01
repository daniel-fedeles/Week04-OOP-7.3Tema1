using System.ComponentModel;

namespace week4_oop_Ex5
{
    public enum Base
    {
        [Description("Regular")]
        Regular,
        [Description("Thick")]
        Thick,
        [Description("Italian")]
        Italian,


    }
    public class PizzaBase
    {
        public string Name { get; set; }

        public void Cost()
        {

        }
        public void Print() { }
    }
}
