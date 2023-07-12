using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
     public  class Opel:ICar,IMexanik
    {
        public void Start()
        {
            Console.WriteLine("Opel is started ");
        }
        public void MaxSpeed()
        {
            Console.WriteLine("220km/h");

        }
        public void Stop()
        {
            Console.WriteLine("Opel has stoped ");
        }
        public void Repair()
        {
            Console.WriteLine("I can repeir this car");
        }
       
    }
}
