using System;
using System.Collections.Generic;
using week4_OOP_Ex3.Models;

namespace week4_OOP_Ex3.Functionalities
{
    public class HotelFunctionality
    {
        public HotelFunctionality()
        {
            this.Hotels = new List<Hotel>();
        }

        public List<Hotel> Hotels { get; set; }

        public void AddHotel(Hotel hotel)
        {
            this.Hotels.Add(hotel);
            Console.WriteLine("Hotel added");
            Console.WriteLine("-------------");
        }

        public void DeleteHotel(Hotel hotel)
        {
            this.Hotels.Remove(hotel);
            Console.WriteLine("Hotel deleted");
            Console.WriteLine("-------------");
        }

        public void PrintAllHotels()
        {
            foreach (var hotel in Hotels)
            {
                hotel.Print();
                Console.WriteLine("-------------");
            }
        }

        public void FindARoom(decimal amount)
        {
            foreach (var hotel in Hotels)
            {
                foreach (var room in hotel.FindARoomBelowAmount(amount))
                {
                    Console.WriteLine($"Rooms found below {amount} {room.DailyRate.Currency} at Hotel: {hotel.Name}");

                    room.Print();
                    Console.WriteLine("-------------");

                }
            }
        }

    }
}
