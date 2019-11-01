using System;
using week4_OOP_Ex3.Functionalities;
using week4_OOP_Ex3.Models;

namespace week4_OOP_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var hf = new HotelFunctionality();

            var hotel = new Hotel("Unirea", "Iasi");

            var rate1 = new Rate(150, "RON");
            var room1 = new Room("room1", rate1, 1, 0);
            hotel.AddRoom(room1);

            var rate2 = new Rate(200, "RON");
            var room2 = new Room("room2", rate2, 1, 1);
            hotel.AddRoom(room2);

            var rate3 = new Rate(250, "RON");
            var room3 = new Room("room3", rate3, 2, 1);
            hotel.AddRoom(room3);

            var rate4 = new Rate(500, "RON");
            var room4 = new Room("room4", rate4, 2, 2);
            hotel.AddRoom(room4);




            hf.AddHotel(hotel);

            hotel.GetPriceForNumberOfRooms(2);

            hf.PrintAllHotels();
            Console.WriteLine("-------------");
            hf.FindARoom(250);

            Console.WriteLine("-------------");
            //            hf.DeleteHotel(hotel);
            //            hf.PrintAllHotels();





        }
    }
}
