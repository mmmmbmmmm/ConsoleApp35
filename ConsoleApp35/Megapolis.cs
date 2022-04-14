using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Megapolis:Place
    {
        public override void Name()
        {
            Console.WriteLine("Megapolis - Name");
        }
        public override void Population()
        {
            Console.WriteLine("Megapolis - Population");
        }
        public void Population_density()
        {
            Console.WriteLine("Megapolis - Population_density");
        }
        
    }
}
