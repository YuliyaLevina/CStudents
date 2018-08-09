using System;
using NUnit.Framework;
using STUDENTS_MARKS_REPORT;

namespace NUnitTests
{
    [TestFixture]
    public class NUnitCStudentsTests
    {
        #region Tests SetUp & TearDown
        [SetUp]
        public void StartTest()
        {
            Console.Out.WriteLine("Start test.");
        }

        [TearDown]
        public void CompleteTest()
        {
            Console.Out.WriteLine("Complete test.");
        }
        #endregion

        #region Verify Single Student's Info
        [TestCase("Kate Ivanova", new int[] { 10, 9, 8, 6, 7 })]
        [TestCase("Александр Петров", new int[] { 7, 10, 5, 8, 7 })]
        public void AddRecordTest_VerifySingleStudentName(string name, int[] marks)
        {
            // Arrange
            CStudents students = new CStudents();

            // Act
            students.AddRecord(name, marks);

            // Assert
            Assert.AreEqual(name, students.studList[0].studentname, "Wrong student's name is added.");
        }

        [TestCase("Kate Ivanova", new int[] { 10, 9, 8, 6, 7 })]
        [TestCase("Александр Петров", new int[] { 7, 10, 5, 8, 7 })]
        public void AddRecordTest_VerifySingleStudentMarks(string name, int[] marks)
        {
            // Arrange
            CStudents students = new CStudents();

            // Act
            students.AddRecord(name, marks);

            // Assert
            Assert.AreEqual(marks, students.studList[0].studentmarks, "Wrong student's marks are added.");
        }

        [TestCase("Kate Ivanova", new int[] { 10, 9, 8, 6, 7 })]
        [TestCase("Александр Петров", new int[] { 7, 10, 5, 8, 7 })]
        public void AddRecordTest_VerifySingleStudentTotalMarks(string name, int[] marks)
        {
            // Arrange
            CStudents students = new CStudents();
            int totalmarks = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                totalmarks += marks[i];
            }

            // Act
            students.AddRecord(name, marks);

            // Assert
            Assert.AreEqual(totalmarks, students.studList[0].totalmarks, "Wrong student's total marks are added.");
        }
        #endregion
    }
}
