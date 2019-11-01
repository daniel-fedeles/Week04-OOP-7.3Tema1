using System;

namespace week4_OOP_Ex3.Models
{
    public class Room
    {
        public Room(string name, Rate dailyRate, int adults, int children)
        {
            this.Name = name;
            this.DailyRate = dailyRate;
            this.Adults = adults;
            this.Children = children;
        }
        public string Name { get; set; }
        public Rate DailyRate { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }

        public void Print()
        {
            Console.WriteLine($"Room with: {Name}, Adults {Adults}, Children: {Children}");
            DailyRate.Print();
            Console.WriteLine();
        }

        public decimal GetPriceForDays(int nrDays)
        {
            return DailyRate.Amount * nrDays;
        }

        public bool RoomsBelowAmount(decimal amount)
        {
            if (DailyRate.Amount < amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
