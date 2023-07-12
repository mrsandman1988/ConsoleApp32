using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public  class Driver
    {
        public ICar car;
        public  string Name = "Armen ";
        public Driver(ICar car)
        {
            this.car = car;
        }
        public void Go()
        {
            car.Start();
            
        }
        public void End()
        {
            car.Stop();
        }
    }
}
