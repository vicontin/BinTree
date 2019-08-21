using Tree;
using Xunit;

namespace BinTreeTest
{
    public class BintreeTest
    {
        [Fact]
        public void CreateBinTree()
        {
            var binTree = new BinTree<int>();
            Assert.NotNull(binTree);
        }

        [Fact]
        public void AddOneValue()
        {
            var expected = 1;
            var binTree = new BinTree<int>();
            binTree.Add(expected);
            var actual = binTree.Find(expected);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddTwoValues()
        {
            var expected1 = 1;
            var expected2 = 2;
            var binTree = new BinTree<int>();
            binTree.Add(expected1);
            binTree.Add(expected2);
            var actual1 = binTree.Find(expected1);
            var actual2 = binTree.Find(expected2);

            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void ShouldReturDefaultWhenElementDoesNotExist()
        {
            var expected = 0;
            var binTree = new BinTree<int>();
            binTree.Add(1);
            var actual = binTree.Find(123);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturDefaultWhenTreeisEmpty()
        {
            var expected = 0;
            var binTree = new BinTree<int>();
            var actual = binTree.Find(123);

            Assert.Equal(expected, actual);
        }
    }
}
