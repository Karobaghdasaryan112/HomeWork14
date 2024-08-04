using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Books
    {
        private string _title;
        private string _description;
        private string _author;
        public Books(string title, string description, string author)
        {
            _title = title;
            _description = description;
            _author = author;
        }
        public string GetInfo()
        {
            return _title + " , " + _description + " , " + _author;
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
