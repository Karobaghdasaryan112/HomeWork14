using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            foreach (var item in zoo.Animals)
            {
                Console.WriteLine(item.GetFullname());
            }
            Console.ReadLine();
        }

    }
}
