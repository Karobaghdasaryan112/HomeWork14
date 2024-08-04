using System.Xml.Linq;

namespace ConsoleApp14
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