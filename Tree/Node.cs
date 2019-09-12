using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BinTreeTest")]
namespace Tree
{
    internal class Node<T> : INode<T>
    {

        private readonly T _value;
        private Node<T> _left;
        private Node<T> _right;

        public bool LeftIsPopulated => _left != null;
        public bool RightIsPopulated => _right != null;
        public T Value => _value;

        internal Node(T value)
        {
            _value = value;
        }

        public void Add(T value)
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

        public Node<T> Find(T value)
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

        public Node<T> GetLowest()
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

        public Node<T> GetHighest()
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

        public void GetSorted(IList<T> list)
        {
            if (LeftIsPopulated)
            {
                _left.GetSorted(list);
            }
            list.Add(_value);
            if (RightIsPopulated)
            {
               _right.GetSorted(list);
            }
        }

        public void GetSortedDescending(IList<T> list)
        {
            if (RightIsPopulated)
            {
                _right.GetSortedDescending(list);
            }
            list.Add(_value);
            if (LeftIsPopulated)
            {
                _left.GetSortedDescending(list);
            }
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
