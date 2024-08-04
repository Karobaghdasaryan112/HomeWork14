using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableForAttraction
{
    internal class AttractionsCity : IEnumerable<Attraction>
    {
        public List<Attraction> _attractions;
        public AttractionsCity(List<Attraction> Attractions)
        {
            _attractions = Attractions;
        }
        public IEnumerator<Attraction> GetEnumerator()
        {
            return new AttractionCityEnumerator(_attractions);
        }
         IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class AttractionCityEnumerator : IEnumerator<Attraction>
    {
        private readonly List<Attraction> _attractions;
        private int _index = -1;
        public AttractionCityEnumerator(List<Attraction> attractions)
        {
            _attractions = attractions;
        }
        public bool MoveNext()
        {
            _index++;
            if (_index < _attractions.Count)
            {
                return true;
            }
            return false;
        }
        public void Reset()
        {
            _index = -1;
        }
        public void Dispose()
        {}
        public Attraction Current
        {
            get
            {
                if (_index < 0 || _index > _attractions.Count)
                {
                    throw new InvalidOperationException();
                }
                return _attractions[_index];
            }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
