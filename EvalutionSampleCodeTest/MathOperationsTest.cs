using EvaluationSampleCode;
using System;

namespace EvaluationSampleCodeTest
{
    [TestClass]
    public class MathOperationsTest
    {
        private MathOperations? _mathOperations;

        [TestInitialize]
        public void Init()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(-1, 1, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(10, -5, 5)]
        public void Add_WithValidInputs_ReturnsSum(int numberOne, int numberTwo, int expected)
        {
                      // Act
            int result = _mathOperations!.Add(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(2, 2, 1)]
        [DataRow(6, 2, 3)]
        [DataRow(10, 2, 5)]
        [DataRow(-6, 2, -3)]
        public void Divide_WithValidInputs_ReturnsQuotient(int numberOne, int numberTwo, float expected)
        {
            // Act
            float result = _mathOperations!.Divide(numberOne, numberTwo);

    
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Divide_ByZero_ThrowsArgumentException()
        {
            // Act
            _mathOperations!.Divide(5, 0);
        }

       
       
    }
}