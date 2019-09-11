using System.Collections.Generic;

namespace Tree
{
    public class BinTree<T> : IBinTree<T>
    {
        private Node<T> _root;

        public void Add(T value)
        {
            if(_root == null)
            {
                _root = new Node<T>(value);
            }
            else
            {
                _root.Add(value);
            }

        }

        public T Find(T value)
        {
            if(_root == null)
            {
                return default;
            }

            var node =_root.Find(value);
            var result = node == null ? default : node.Value;
            return result;
        }

        public T GetLowest()
        {
            if (_root == null)
            {
                return default;
            }

            var result = _root.GetLowest();

            return result.Value;
        }

        public T GetHighest()
        {
            if (_root == null)
            {
                return default;
            }

            var result = _root.GetHighest();

            return result.Value;
        }

        public IEnumerable<T> GetSorted()
        {
            if (_root == null)
            {
                return default;
            }

            IList<T> list = new List<T>();
            _root.GetSorted(list);

            return list;
        }
    }
}
