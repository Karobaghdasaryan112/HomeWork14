using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Route route = new Route();
            foreach (var item in route.stop)
            {
                Console.Write(item.GetStopInfo());
            }
            Console.ReadLine();
        }
    }
}
