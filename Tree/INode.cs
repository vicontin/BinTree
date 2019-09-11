using System.Collections;
using System.Collections.Generic;

namespace Tree
{
    internal interface INode<T>
    {
        bool LeftIsPopulated { get; }
        bool RightIsPopulated { get; }
        T Value { get; }
        void Add(T value);
        Node<T> Find(T value);
        Node<T> GetLowest();
        Node<T> GetHighest();
        void GetSorted(IList<T> list);
        void GetSortedDescending(IList<T> list);
    }
}