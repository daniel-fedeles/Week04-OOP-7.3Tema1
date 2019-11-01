using System;
using System.Collections.Generic;

namespace week4_OOP_Ex3.Models
{
    public class Hotel
    {
        public Hotel(string name, string city)
        {
            Name = name;
            City = city;
            Rooms = new List<Room>();
        }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Room> Rooms { get; }

        public decimal GetPriceForNumberOfRooms(int numberOfRooms)
        {
            decimal sum = 0;

            for (int i = 0; i < Rooms.Count; i++)
            {
                if (i <= numberOfRooms)
                {
                    sum += Rooms[i].DailyRate.Amount;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine($"For selected number of rooms {numberOfRooms}, the price is: {sum}");
            return sum;
        }

        public void AddRoom(Room room)
        {
            if (room.Adults != 0)
            {
                Rooms.Add(room);
            }
            else
            {
                Console.WriteLine("Insert numbers of adults");
            }
        }

        public void DeleteRoom(Room room)
        {
            if (room != null)
            {
                Rooms.Remove(room);
            }
        }

        public List<Room> FindARoomBelowAmount(decimal amount)
        {
            var roomsList = new List<Room>();

            foreach (var room in Rooms)
            {
                if (room.RoomsBelowAmount(amount))
                {
                    roomsList.Add(room);
                }
            }

            return roomsList;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Hotel with Name: {Name}, City: {City}");
            Console.WriteLine();
            foreach (var room in Rooms)
            {
                room.Print();
            }


        }
    }
}
