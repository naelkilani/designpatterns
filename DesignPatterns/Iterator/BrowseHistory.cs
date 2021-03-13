using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    public class BrowseHistory<T>
    {
        private readonly List<T> _history = new List<T>();

        public void Push(T item)
        {
            _history.Add(item);
        }

        public T Pop()
        {
            var lastIndex = _history.Count - 1;

            var item = _history.ElementAt(lastIndex);
            _history.RemoveAt(lastIndex);

            return item;
        }

        public IIterator<T> GetIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator : IIterator<T>
        {
            private readonly BrowseHistory<T> _browseHistory;
            private int _index;

            public ListIterator(BrowseHistory<T> browseHistory)
            {
                _browseHistory = browseHistory;
            }

            public bool HasNext()
            {
                return _index < _browseHistory._history.Count;
            }

            public T Current()
            {
                return _browseHistory._history.ElementAt(_index);
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}