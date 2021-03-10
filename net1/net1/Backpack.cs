using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace net1
{
    class Backpack
    {
        private List<item> items = new List<item>();
        private int size;
        private int remainingSize;

        public Backpack(int newSize) {
            size = newSize;
            remainingSize = newSize;
        }
        public bool addNewItem(item newItem) {
            if (newItem.get_weight() > remainingSize)
                return false;
            remainingSize -= newItem.get_weight();
            items.Add(newItem);

            return true;
        }

        public int getSize()
        {
            return size;
        }
        public int getRemainingSize()
        {
            return remainingSize;
        }


    }
}
