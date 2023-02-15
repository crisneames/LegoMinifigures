using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures
{
    public class DarthVader
    {
        public string Name { get; set; }
        public string Mask { get; set; }

        public string Accessory { get; set; }

        public DarthVader(string name, string mask, string accessory)
        {
            Name = name;
            Mask = mask;
            Accessory = accessory;
        }

        public void UseTheForce() 
        {
            Console.WriteLine($"{Name} breathes heavily through his {Mask} while wielding his {Accessory}");
        }   
    }
}
