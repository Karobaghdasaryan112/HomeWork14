using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooWithYieldReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            foreach (Animal animal in zoo)
            {
                Console.WriteLine(animal.GetFullname());
            }
            Console.ReadLine();
        }
    }
}
