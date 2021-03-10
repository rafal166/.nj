using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net1
{
    class item
    {
        private int weight;
        private int value;

        public item(int weight, int value)
        {
            this.weight = weight;
            this.value = value;
        }

        public int get_weight()
        {
            return weight;
        }

        public int get_value()
        {
            return value;
        }

    }
}
