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
    public class TestGradeCollection
    {
        private Grade CreateGrade()
        {
            var student = new Student() { Naam = "Victor" };
            return new Grade()
            {
                Student = student
            };
        }

        [TestMethod]
        public void GivenAddGradeCollectionHasGrade()
        {
            var gradeCollection = new GradeCollection();
            var grade = CreateGrade();

            Assert.AreEqual(0, gradeCollection.Count);
            gradeCollection.AddGrade(grade);
            Assert.AreEqual(1, gradeCollection.Count);
        }

        [TestMethod]
        public void GivenClearCollectionThenGradeCollectionIsEmpty()
        {
            var grade = CreateGrade();
            var gradeCollection = new GradeCollection();
            Assert.AreEqual(0, gradeCollection.Count);
            gradeCollection.AddGrade(grade);
            Assert.AreEqual(1, gradeCollection.Count);
            gradeCollection.Clear();
            Assert.AreEqual(0, gradeCollection.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenANullIsAddedToCollectionThenCollectionThrowsArgumentNullException()
        {
            GradeCollection collection = new GradeCollection();
            collection.AddGrade(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenTheSameGradeIsAddedTwiceToCollectionThenCollectionThrowsArgumentException()
        {
            GradeCollection collection = new GradeCollection();
            var grade = CreateGrade();
            collection.AddGrade(grade);
            collection.AddGrade(grade);
        }
    }
}