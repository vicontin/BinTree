using System.Collections;
using System.Collections.Generic;

namespace Tree
{
    public interface IBinTree<T>
    {
        void Add(T value);
        T Find(T value);
        T GetLowest();
        T GetHighest();
        IEnumerable<T> GetSorted();
    }
}