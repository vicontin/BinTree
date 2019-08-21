using System;

namespace Tree
{
    public class BinTree<T>
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
            else
            {
                var node =_root.Find(value);
                var result = node == null ? default : node.Value;
                return result;
            }
        }

    }
}
