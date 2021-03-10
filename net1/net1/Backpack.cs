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
        private int size;
        private int remainingSize;

        Backpack(int newSize) {
            size = newSize;
            remainingSize = newSize;
        }
        public void addNewItem(int itemSize) {
            remainingSize -= itemSize;
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
