using Tree;
using Xunit;

namespace BinTreeTest
{
    public class NodeTests
    {
        private Node<int> _sut;

        #region CreateAndAdd

        [Fact]
        public void CreateNode()
        {
            _sut = new Node<int>(1);
            Assert.NotNull(_sut);
            Assert.Equal(1, _sut.Value);
        }

        [Fact]
        public void CreateNodeAndAddLeftValue()
        {
            var expected = 10;
            _sut = new Node<int>(expected);
            _sut.Add(2);
            Assert.Equal(expected, _sut.Value);
            Assert.True(_sut.LeftIsPopulated);
        }

        [Fact]
        public void CreateNodeAndAddRightValue()
        {
            var expected = 10;
            _sut = new Node<int>(expected);
            _sut.Add(20);
            Assert.Equal(expected, _sut.Value);
            Assert.True(_sut.RightIsPopulated);
        }

        [Fact]
        public void CreateNodeAndAddLeftAndRightValues()
        {
            var expected = 10;
            _sut = new Node<int>(expected);
            _sut.Add(20);
            _sut.Add(1);
            Assert.Equal(expected, _sut.Value);
            Assert.True(_sut.RightIsPopulated);
            Assert.True(_sut.RightIsPopulated);
        }

        [Fact]
        public void CreateNodeAndAddTwoRightsAndLeftShouldBeNull()
        {
            var expected = 10;
            _sut = new Node<int>(expected);
            _sut.Add(20);
            _sut.Add(30);
            Assert.Equal(expected, _sut.Value);
            Assert.True(_sut.RightIsPopulated);
            Assert.False(_sut.LeftIsPopulated);
        }

        [Fact]
        public void CreateNodeAndAddTwoLeftsAndRighttShouldBeNull()
        {
            var expected = 10;
            _sut = new Node<int>(expected);
            _sut.Add(5);
            _sut.Add(1);
            Assert.Equal(expected, _sut.Value);
            Assert.True(_sut.LeftIsPopulated);
            Assert.False(_sut.RightIsPopulated);
        }

        #endregion

        #region Find

        [Fact]
        public void AddValueAndFindIt()
        {
            var expected = 10;
            _sut = new Node<int>(expected);
            var actual = _sut.Find(expected);
            Assert.Equal(expected, actual.Value);
        }

        [Fact]
        public void AddLeftValueAndFindIt()
        {
            var seed = 20;
            var expected = 10;
            _sut = new Node<int>(seed);
            _sut.Add(expected);
            var actual = _sut.Find(expected);
            Assert.Equal(expected, actual.Value);
        }

        [Fact]
        public void AdRightValueAndFindIt()
        {
            var seed = 10;
            var expected = 20;
            _sut = new Node<int>(seed);
            _sut.Add(expected);
            var actual = _sut.Find(expected);
            Assert.Equal(expected, actual.Value);
        }

        [Fact]
        public void AddLeftValueAndFindBoth()
        {
            var seed = 20;
            var expected = 10;
            _sut = new Node<int>(seed);
            _sut.Add(expected);
            var actual = _sut.Find(expected);
            var actualSeed = _sut.Find(seed);
            Assert.Equal(expected, actual.Value);
            Assert.Equal(seed, actualSeed.Value);
        }

        [Fact]
        public void AddRightValueAndFindBoth()
        {
            var seed = 10;
            var expected = 20;
            _sut = new Node<int>(seed);
            _sut.Add(expected);
            var actual = _sut.Find(expected);
            var actualSeed = _sut.Find(seed);
            Assert.Equal(expected, actual.Value);
            Assert.Equal(seed, actualSeed.Value);
        }

        [Fact]
        public void AddRightAndLeftValueAndFindAll()
        {
            var seed = 20;
            var expectedLeft = 10;
            var expectedRight = 30;
            _sut = new Node<int>(seed);
            _sut.Add(expectedLeft);
            _sut.Add(expectedRight);
            var actualSeed = _sut.Find(seed);
            var actualLeft = _sut.Find(expectedLeft);
            var actualRight = _sut.Find(expectedRight);
            Assert.Equal(seed, actualSeed.Value);
            Assert.Equal(expectedLeft, actualLeft.Value);
            Assert.Equal(expectedRight, actualRight.Value);
        }

        #endregion

        #region

        [Fact]
        public void AddValuesAndFindLowestValue()
        {
            var seed = 20;
            var expectedLeft = 10;
            var expectedRight = 30;
            var expectedLowest = 3;
            _sut = new Node<int>(seed);
            _sut.Add(expectedLeft);
            _sut.Add(expectedRight);
            _sut.Add(expectedLowest);
            //var actualLowest = _sut.GetLowest();

        }

        #endregion
    }
}
