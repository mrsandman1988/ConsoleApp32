using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public  class BMW:ICar
    {
        public void Start()
        {
            Console.WriteLine("BMW is strated");
        }
        public void MaxSpeed()
        {
            Console.WriteLine("260 km/h");
        }
        public void Stop()
        {
            Console.WriteLine("BMW has stoped ");
        }

    }
}
