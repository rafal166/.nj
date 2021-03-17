using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net1
{
    public class item
    {
        private int weight;
        private int value;

        public item(int weight=0, int value=0)
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

        public void set_weight(int weight)
        {
            this.weight = weight;
        }

        public void set_value(int value)
        {
            this.value = value;
        }

    }
}
