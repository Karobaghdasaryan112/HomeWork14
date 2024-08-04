using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableForAttraction
{
    internal class Attraction
    {
        private string _name;
        private string _description;
        private string _category;
        public Attraction(string name, string description, string category)
        {
            _name = name;
            _description = description;
            _category = category;
        }
        public override string ToString()
        {
            return _name + " , " + _description + " , " + _category;
        }
    }
}
