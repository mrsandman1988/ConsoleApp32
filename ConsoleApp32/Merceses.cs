using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public  class Mercedes:ICar,IMexanik
    {
        public void Start()
        {
            Console.WriteLine("Mercedes is started ");
        }
        public void MaxSpeed()
        {
            Console.WriteLine("250km/h");
        }
        public void Stop()
        {
            Console.WriteLine("Mercedes has stoped ");
        }
        public void Repair()
        {
            Console.WriteLine("I can repeir this car");
        }

    }
}
