using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Area:Place
    {
        public override void Name()
        {
            Console.WriteLine("Area - Name");
        }
        public override void Population()
        {
            Console.WriteLine("Area - Population");
        }
        public void Squarer()
        {
            Console.WriteLine("Area - Squarer");
        }
      
    }
}
