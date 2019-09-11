using System.Collections.Generic;
using Tree;
using Xunit;

namespace BinTreeTest
{
    public class BintreeTest
    {
        private IBinTree<int> _sut;
        [Fact]
        public void CreateBinTree()
        {
            _sut = new BinTree<int>();
            Assert.NotNull(_sut);
        }

        [Fact]
        public void AddOneValue()
        {
            var expected = 1;
            _sut = new BinTree<int>();
            _sut.Add(expected);
            var actual = _sut.Find(expected);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddTwoValues()
        {
            var expected1 = 1;
            var expected2 = 2;
            _sut = new BinTree<int>();
            _sut.Add(expected1);
            _sut.Add(expected2);
            var actual1 = _sut.Find(expected1);
            var actual2 = _sut.Find(expected2);

            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void ShouldReturnDefaultWhenElementDoesNotExist()
        {
            var expected = 0;
            _sut = new BinTree<int>();
            _sut.Add(1);
            var actual = _sut.Find(123);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnDefaultWhenTreeIsEmpty()
        {
            var expected = 0;
            _sut = new BinTree<int>();
            var actual = _sut.Find(123);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnDefaultWhenGetLowestIsCalledWithEmptyTree()
        {
            int expected = default;
            _sut = new BinTree<int>();

            var actual = _sut.GetLowest();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnLowestValue()
        {
            var expected = 1;
            _sut = new BinTree<int>();
            _sut.Add(5);
            _sut.Add(1);
            _sut.Add(2);

            var actual = _sut.GetLowest();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnDefaultWhenGeHighestIsCalledWithEmptyTree()
        {
            int expected = default;
            _sut = new BinTree<int>();

            var actual = _sut.GetHighest();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnHightestValue()
        {
            var expected = 10;

            _sut = new BinTree<int>();
            _sut.Add(1);
            _sut.Add(10);
            _sut.Add(5);

            var actual = _sut.GetHighest();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnDefaultWhenGetSortedListIsCalledOnAnEmptyTree()
        {
            IEnumerable<int> expected = null;
            _sut = new BinTree<int>();

            var actual = _sut.GetSorted();

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ShouldGetSortedList()
        {
            var expected = new List<int> {1, 2, 3, 4, 5};

            _sut = new BinTree<int>();
            _sut.Add(4);
            _sut.Add(1);
            _sut.Add(2);
            _sut.Add(5);
            _sut.Add(3);

            var actual = _sut.GetSorted();

            Assert.Equal(expected, actual);
        }
    }
}
