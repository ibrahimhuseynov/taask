using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 :Create a room");
            Console.WriteLine("2 :add room");
            Console.WriteLine("3 :make reserve");
            Console.WriteLine("0 :exit");
            Console.WriteLine( "reqem daxil edin :");
            Room room1 = new Room("azad", 12, 32);
            int number=Convert.ToInt32(Console.ReadLine());
            string room;
            do
            {

              
            } while (number == 0);
        }
    }
}
