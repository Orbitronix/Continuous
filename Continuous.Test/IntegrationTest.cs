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
    public class IntegrationTest
    {
        private static Grade CreateGrade(Student student, float score)
        {
            var grade = new Grade()
            {
                Student = student
            };

            grade.SetScore(score);
            return grade;
        }

        [TestMethod]
        public void GivenAStudenHasGradesThenTheCalculatorShouldCalculateAverageCorrectly()
        {
            var student1 = new Student()
            {
                Naam = "Bozo"
            };

            var student2 = new Student()
            {
                Naam = "Victor"
            };

            float expectedAverageStudent1 = (5f + 10f) / 2;
            float expectedAverageStudent2 = (8f + 5f) / 2;

            var gradeCollection = new GradeCollection();
            gradeCollection.AddGrade(CreateGrade(student1, 5f));
            gradeCollection.AddGrade(CreateGrade(student1, 10f));
            gradeCollection.AddGrade(CreateGrade(student2, 8f));
            gradeCollection.AddGrade(CreateGrade(student2, 5f));

            var actualAverageStudent1 = AverageCalculator.CalculateMeanAverage(gradeCollection.GetGradesForStudent(student1));
            var actualAverageStudent2 = AverageCalculator.CalculateMeanAverage(gradeCollection.GetGradesForStudent(student2));

            Assert.AreEqual(expectedAverageStudent1, actualAverageStudent1, 0.001f);
            Assert.AreEqual(expectedAverageStudent2, actualAverageStudent2, 0.002f);
        }
    }
}