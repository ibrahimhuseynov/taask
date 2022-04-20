using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Room
    {
        public int Id { get; } 
        private int _id;    
        public Room(string name,double price,int personcapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;  
            PersonCapacity = personcapacity;
        }
        public string Name { get; set; }
        public Double Price { get; set; }   
        public int PersonCapacity { get; set; } 
       public  bool IsAvailable { get; set; }  
        public override string ToString()
        {
         return ($"id-{Id} \n name-{Name}\n price-{Price}\n PersonCapacity -{ PersonCapacity}\n IsAvailable-{IsAvailable}");
        }

    }
}
