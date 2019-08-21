using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Tree
{
    internal static class NodeComparer<T>
    {
       
        [Pure]
        internal static NodeEqualityEnum Compare(T value1, T value2)
        {
            var comparison = Comparer<T>.Default.Compare(value1, value2);

            return (NodeEqualityEnum)comparison;
        }
    }
}
