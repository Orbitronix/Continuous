using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continuous.Test
{
    [TestClass]
    public class TestAverageCalculator
    {
        private class ValueProviderMock : IValueProvider
        {
            public float Value
            {
                get; set;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullCalculatorThrowsArgumentNullException()
        {
            float result = AverageCalculator.CalculateMeanAverage<ValueProviderMock>(null);
        }

        [TestMethod]
        public void GivenEmptyCollectionCalculatorReturns0()
        {
            float result = AverageCalculator.CalculateMeanAverage(new List<ValueProviderMock>());
            Assert.AreEqual(0, result, 0.001f);
        }

        [TestMethod]
        public void GivenACorrectCollectionIsProvidedThenTheCalculatorReturnsACorrectAverage()
        {
            var input = new List<ValueProviderMock>
            {
                new ValueProviderMock() { Value = 10 },
                new ValueProviderMock() { Value = 6 },
                new ValueProviderMock() { Value = 7 }
            };
            var expected = (10f + 6f + 7f) / 3;
            float result = AverageCalculator.CalculateMeanAverage(input);
            Assert.AreEqual(expected, result, 0.001f);
        }
    }
}
