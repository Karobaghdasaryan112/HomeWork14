using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
