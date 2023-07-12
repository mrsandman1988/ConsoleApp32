using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public  class Mexanik
    {
        public IMexanik mexanik;
        public Mexanik(IMexanik mexanik)
        {
            this.mexanik = mexanik;

        }
        public void Fix()
        {
            mexanik.Repair();
        }
    }
}
