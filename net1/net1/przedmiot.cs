using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net1
{
    class przedmiot
    {
        private int waga;
        private int wartosc;

        public przedmiot(int waga, int wartosc)
        {
            this.waga = waga;
            this.wartosc = wartosc;
        }

        public int get_weight()
        {
            return waga;
        }

        public int get_value()
        {
            return wartosc;
        }

    }
}
