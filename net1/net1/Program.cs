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

            RandomNumberGenerator rng = new RandomNumberGenerator(seed);
            List<item> items = new List<item>();
            for(int i=0;i<n;i++)
            {
                items.Add(new item(rng.nextInt(1, 29), rng.nextInt(1, 29)));
            }





        }
    }
}
