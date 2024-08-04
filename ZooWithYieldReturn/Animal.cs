using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooWithYieldReturn
{
    internal class Animal
    {
        private string _name { get; set; }
        private string _description { get; set; }
        private string _category { get; set; }
        public Animal(string name, string description, string category)
        {
            _name = name;
            _description = description;
            _category = category;
        }
        public string GetFullname()
        {
            return _name + " , " + _description + " , " + _category;
        }
    }
}
