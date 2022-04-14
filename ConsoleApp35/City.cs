using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class City:Place
    {
        public override void Name()
        {
            Console.WriteLine("City - Name");
        }

        public override void Population()
        {
            Console.WriteLine("City - Population");
        }

        public void Economy()
        {
            Console.WriteLine("City - Econmy");
        }

    }
}
