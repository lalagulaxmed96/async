using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Room
    {
        public Room(string name, double price, int personCapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            
            
        }
        private static int _id;
        public int Id { get; set; }
        public string Name {  get; set; }
        public double Price {  get; set; }
        public int PersonCapacity {  get; set; }
        public bool IsAvaible { get; set; } = true;

        public override string ToString()
        {
            return $"Name{Name}, Price{Price}, PersonCapacity{PersonCapacity}, IsAvaible{IsAvaible}";
        }

    }
}
