using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFactory_v._1
{
    abstract class Inventory
    {
        protected Dictionary<string, int> materials { get; set; } = new Dictionary<string, int>();
        public Inventory()
        {
            materials.Add("Metal", 0);
            materials.Add("Rubber", 0);
            materials.Add("Wood", 0);
        }

        public void AddInventory(string material, int numberOf)
        {

            materials[material] = materials[material] + numberOf;

        }

        public void PrintInventory()
        {
            foreach (var de in materials)
            {
                Console.WriteLine($"{de.Key} : {de.Value}");
            }
        }

    }
}
