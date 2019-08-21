using Tree;
using Xunit;

namespace BinTreeTest
{
    public class UnitTest1
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
            var binTree = new BinTree<int>();
            binTree.Add(1);
        }
        [Fact]
        public void AddTwoValues()
        {
            var binTree = new BinTree<int>();
            binTree.Add(1);
            binTree.Add(2);
        }
    }
}
