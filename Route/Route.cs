using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route
{
    internal class Route 
    {
        public Stop[] stop = new Stop[]
        {
            new Stop("Central Station", "Main hub of the city", new TimeSpan(9, 0, 0)),
            new Stop("City Park", "Beautiful park with a lake", new TimeSpan(10, 30, 0)),
            new Stop("Museum", "Historical museum with exhibitions", new TimeSpan(12, 15, 0)),
            new Stop("Art Gallery", "Modern art gallery with new exhibits", new TimeSpan(14, 0, 0)),
            new Stop("Shopping Center", "Popular place for shopping and dining", new TimeSpan(16, 45, 0)),
            new Stop("Theater", "Venue for live performances and shows", new TimeSpan(19, 30, 0)),
        };
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)new RouteEnumerator(stop);
        }
    }
    internal class RouteEnumerator 
    {
        private Stop[] stops;
        private int _currentIndex = -1;
        public RouteEnumerator(Stop[] stops)
        {
            this.stops = stops;
        }
        public bool MoveNext()
        {
            _currentIndex++;
            if(_currentIndex < stops.Length )
            {
                return true;
            }
            return false;
        }
        public void Reset()
        {
            _currentIndex = -1;
        }
        public object Current()
        {
            if(_currentIndex < 0 || _currentIndex >= stops.Length)
            {
                throw new InvalidOperationException();
            }
            return stops[_currentIndex];
        }
    }
}
