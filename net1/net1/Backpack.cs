using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace net1
{
    public class Backpack
    {
        private List<item> items = new List<item>();
        private int size;
        private int remainingSize;
        private int totalValue = 0;

        public Backpack(int newSize) {
            size = newSize;
            remainingSize = newSize;
        }
        public bool addNewItem(item newItem) {
            if (newItem.get_weight() > remainingSize)
                return false;
            remainingSize -= newItem.get_weight();
            items.Add(newItem);
            totalValue += newItem.get_value();

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

        public List<item> GetItems()
        {
            return items;
        }

        public int getValue()
        {
            return totalValue;
        }


    }
}
