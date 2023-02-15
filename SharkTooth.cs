using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures
{
    public class SharkTooth
    {
        public string Name { get; set; }
        public string Food { get; set; }

        public string Accessory { get; set; }

        public SharkTooth(string name, string food, string accessory)
        {
            Name = name;
            Food = food;
            Accessory = accessory;
        }

        public void Attack()
        {
            Console.WriteLine($"My name is {Name} and like to eat {Food} while I'm wearing my {Accessory}.");
        }
    }

    
}

