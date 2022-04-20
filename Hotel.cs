using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hotel
    {
        public string Name { get; set; }
        private Room[] Rooms=new Room[0];
        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length+1);
            Rooms[Rooms.Length-1]=room;
        }
        public void  MakeReservation(int roomId)
        {
           foreach(var item in Rooms)
            {
                if (roomId == item.Id)
                {
                    if (item.IsAvailable == false)
                    {
                        Console.WriteLine("room is full");
                    }
                }
            }  
        }
        public Hotel(string name)
        {
            Name = name;    
        }
    }
}
