using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures
{
    public class BobTheBuilder
    {
        public string Name { get; set; }
        public string Hat { get; set; }

        public string Accessory { get; set; }

        public BobTheBuilder(string name, string hat, string accessory)
        {
            Name = name;
            Hat = hat;
            Accessory = accessory;
        }

        public void HeCanDoIt()
        {
            Console.WriteLine($"{Name} can build anything with his {Accessory} while wearing his {Hat} hat.");
        }
    }
}
