using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route
{
    internal class Stop
    {
        private string _name;
        private string _description;
        private TimeSpan _time;
        public Stop(string name, string description, TimeSpan time)
        {
            _name = name;
            _description = description;
            _time = time;
        }
        public string GetStopInfo()
        {
            return  _name + " , " + _description +  " , " + _time;
        }
    }
}
