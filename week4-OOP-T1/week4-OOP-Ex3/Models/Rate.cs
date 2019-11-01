using System;

namespace week4_OOP_Ex3.Models
{
    public class Rate
    {
        public Rate(decimal amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }
        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public void Print()
        {
            Console.WriteLine($"Rate with: {Amount} {Currency} per day");
        }
    }
}
