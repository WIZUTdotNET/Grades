using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculateHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(90f);
            book.AddGrade(50f);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90f, stats.HighestGrade);
        }

        [TestMethod]
        public void PassByValue()
        {
            GradeBook book = new GradeBook();
            book.Name = "null";
            SetName(book);

            Assert.AreEqual("Not set", book.Name);
        }

        private void SetName(GradeBook book)
        {
            book.Name = "Not set";
        }
    }
}
