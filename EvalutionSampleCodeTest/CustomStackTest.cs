using EvaluationSampleCode;

namespace EvaluationSampleCodeTest
{
    [TestClass]
    public class CustomStackTest
    {
        private CustomStack? _stack;

        [TestInitialize]
        public void Init()
        {
            _stack = new CustomStack();
        }

        [TestMethod]
        public void Count_EmptyStack_ReturnsZero()
        {
            // Act
            var result = _stack!.Count();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Push_AddingValue_IncreasesCount()
        {
            // Act
            _stack!.Push(1);

            // Assert
            Assert.AreEqual(1, _stack.Count());
        }

        [TestMethod]
        public void Pop_WithOneItem_ReturnsItemAndEmptiesStack()
        {
            // Arrange
            _stack!.Push(1);

            // Act
            var result = _stack.Pop();

            // Assert
            Assert.AreEqual(1, result);
            Assert.AreEqual(0, _stack.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(CustomStack.StackCantBeEmptyException))]
        public void Pop_EmptyStack_ThrowsStackCantBeEmptyException()
        {
            // Act
            _stack!.Pop();
        }
    }
}