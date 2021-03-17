using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int seed = 1;
            int size = 50;
            RandomNumberGenerator rng = new RandomNumberGenerator(seed);
            List<item> items = new List<item>();
            Backpack bag = new Backpack(size);

            for (int i = 0; i < n; i++)
            {
                items.Add(new item(value: rng.nextInt(1, 29)));
            }
            for (int i = 0; i < n; i++)
            {
                items[i].set_weight(rng.nextInt(1, 29));
                bag.addNewItem(items[i]);
            }


            Console.WriteLine(bag.getRemainingSize());
            Console.WriteLine(bag.getValue());

        }
    }
}
