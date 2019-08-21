using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BinTreeTest")]
namespace Tree
{
    internal class Node<T>
    {

        private T _value;
        private Node<T> _left;
        private Node<T> _right;

        internal bool LeftIsPopulated => _left != null;
        internal bool RightIsPopulated => _right != null;
        public T Value => _value;

        internal Node(T value)
        {
            _value = value;
        }

        internal void Add(T value)
        {
            if (Comparer<T>.Default.Compare(_value, value) > 0)
            {
                // Go Left <
                AddToChildNode(ref _left, value);
            }
            else
            {
                //Go Right >
                AddToChildNode(ref _right, value);
            }
        }

        internal Node<T> Find(T value)
        {
            var currentNode = this;

            while (currentNode != null)
            {
                var comparison = NodeComparer<T>.Compare(value, currentNode.Value);
                if(comparison == NodeEqualityEnum.Equal)
                {
                    return currentNode;
                }
                else if(comparison == NodeEqualityEnum.LessThan)
                {
                    currentNode = this._left;
                }
                else
                {
                    currentNode = this._right;
                }
            }
            return null;
        }

        internal Node<T> GetLowest()
        {
            var currentNode = this;
            while(currentNode != null)
            {
                if(currentNode._left == null)
                {
                    return currentNode;
                }
                currentNode = currentNode._left;
            }
            return null;
        }

        internal Node<T> GetHighest()
        {
            var currentNode = this;
            while (currentNode != null)
            {
                if (currentNode._right == null)
                {
                    return currentNode;
                }
                currentNode = currentNode._right;
            }
            return null;
        }

        private static void AddToChildNode(ref Node<T> child, T value)
        {
            if(child == null)
            {
                child = new Node<T>(value);
            }
            else
            {
                child.Add(value);
            }
        }
    }
}
