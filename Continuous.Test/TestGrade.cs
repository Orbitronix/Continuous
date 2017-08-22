using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace Continuous.Test
{
    [TestClass]
    public class TestGrade
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenGradeSmallerThan1ShouldThrowArgumentException()
        {
            var grade = new Grade();
            grade.SetScore(0.5f);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenGradeLargerThan10ShouldThrowArgumentException()
        {
            var grade = new Grade();
            grade.SetScore(11f);
        }

        [TestMethod]
        public void GivenGradeBetween1And10ShouldSetGradeValue()
        {
            var value = 8f;
            var grade = new Grade();
            grade.SetScore(value);
            Assert.AreEqual(value, grade.Value, 0.001f);
        }
    }
}