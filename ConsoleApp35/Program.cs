using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            Megapolis megapolis = new Megapolis();
            Area area = new Area();


            megapolis.Name();
            megapolis.Population();
            megapolis.Population_density();

            
            city.Name();
            city.Population();
            city.Economy();
          

            area.Name();
            area.Population();
            area.Squarer();
        }
    }
}