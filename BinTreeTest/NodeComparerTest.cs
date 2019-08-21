using Tree;
using Xunit;

namespace BinTreeTest
{
    public class NodeComparerTest
    {
        [Fact]
        public void CompareEqualValues()
        {
            var expected = NodeEqualityEnum.Equal;
            var actual = NodeComparer<int>.Compare(1, 1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CompareLessThan()
        {
            var expected = NodeEqualityEnum.LessThan;
            var actual = NodeComparer<int>.Compare(10, 20);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CompareGreaterThan()
        {
            var expected = NodeEqualityEnum.GreaterThan;
            var actual = NodeComparer<int>.Compare(100, 20);
            Assert.Equal(expected, actual);
        }
    }
}
