using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableForAttraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Attraction> attractionsList = new List<Attraction>()
            {
                new Attraction("Central Park", "A large public park in New York City.", "Park"),
                new Attraction("Metropolitan Museum of Art", "A major art museum located in New York City.", "Museum"),
                new Attraction("Times Square", "A bustling commercial and entertainment hub in New York City.", "Entertainment"),
            };
            AttractionsCity attractions = new AttractionsCity(attractionsList);
            foreach (var item in attractions)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
