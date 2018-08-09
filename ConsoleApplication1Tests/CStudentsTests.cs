using Microsoft.VisualStudio.TestTools.UnitTesting;
using STUDENTS_MARKS_REPORT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_MARKS_REPORT.Tests
{
    [TestClass()]
    public class CStudentsTests
    {
        [TestInitialize]
        public void StartTest()
        {
            Console.Out.WriteLine("Start test.");
        }

        #region Verify single student's info
        [TestMethod()]
        public void AddRecordTest_VerifySingleStudentName()
        {
            // Arrange
            CStudents students = new CStudents();
            String name = "Ivan Ivanov";
            int[] marks = new int[] { 7, 6, 8, 9, 10 };

            // Act
            students.AddRecord(name, marks);

            // Asserts
            Assert.AreEqual(name, students.studList[0].studentname, "Incorrect student's name.");
        }

        [TestMethod()]
        public void AddRecordTest_VerifySingleStudentMarks()
        {
            // Arrange
            CStudents students = new CStudents();
            String name = "Ivan Ivanov";
            int[] marks = new int[] { 7, 6, 8, 9, 10 };

            // Act
            students.AddRecord(name, marks);

            // Asserts
            Assert.AreEqual(marks, students.studList[0].studentmarks, "Incorrect student's marks.");
        }

        [TestMethod()]
        public void AddRecordTest_VerifySingleStudentTotalMark()
        {
            // Arrange
            CStudents students = new CStudents();
            String name = "Ivan Ivanov";
            int[] marks = new int[] { 7, 6, 8, 9, 10 };
            int totalmark = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                totalmark += marks[i];
            }

            // Act
            students.AddRecord(name, marks);

            // Asserts
            Assert.AreEqual(totalmark, students.studList[0].totalmarks, "Incorrect student's total mark.");
        }
        #endregion

        #region Verify multiple students' info

        [TestMethod()]
        public void AddRecordTest_VerifyMultipleStudentsName()
        {
            // Arrange
            CStudents studentsToVerify = new CStudents();
            CStudents studentsToCompare = new CStudents();
            int[] marks = new int[] { 7, 6, 8, 9, 10 };

            // The 1st student's info
            String name = "Ivan Ivanov";
            studentsToCompare.studList.Add(new CStudentDetails());
            studentsToCompare.studList[0].studentname = name;

            // The 2nd student's info
            name = "Kate Ivanova";
            studentsToCompare.studList.Add(new CStudentDetails());
            studentsToCompare.studList[1].studentname = name;

            // The 3rd student's info
            name = "Igor Petrov";
            studentsToCompare.studList.Add(new CStudentDetails());
            studentsToCompare.studList[2].studentname = name;;

            // Act
            studentsToVerify.AddRecord(studentsToCompare.studList[0].studentname, marks);
            studentsToVerify.AddRecord(studentsToCompare.studList[1].studentname, marks);
            studentsToVerify.AddRecord(studentsToCompare.studList[2].studentname, marks);

            // Asserts
            for (int i = 0; i < studentsToVerify.MaxStudents; i++)
            {
                Assert.AreEqual(studentsToCompare.studList[i].studentname, studentsToVerify.studList[i].studentname, "Incorrect name of the " + i.ToString() + " student.");
            }
        }

        [TestMethod()]
        public void AddRecordTest_VerifyMultipleStudentsMarks()
        {
            // Arrange
            CStudents studentsToVerify = new CStudents();
            CStudents studentsToCompare = new CStudents();

            // The 1st student's info
            String name = "Ivan Ivanov";
            int[] marks = new int[] { 7, 6, 8, 9, 10 };

            studentsToCompare.studList.Add(new CStudentDetails());
            studentsToCompare.studList[0].studentname = name;
            studentsToCompare.studList[0].studentmarks = marks;

            // The 2nd student's info
            name = "Kate Ivanova";
            marks = new int[] { 9, 9, 8, 10, 10 };

            studentsToCompare.studList.Add(new CStudentDetails());
            studentsToCompare.studList[1].studentname = name;
            studentsToCompare.studList[1].studentmarks = marks;

            // The 3rd student's info
            name = "Igor Petrov";
            marks = new int[] { 7, 5, 10, 9, 10 };

            studentsToCompare.studList.Add(new CStudentDetails());
            studentsToCompare.studList[2].studentname = name;
            studentsToCompare.studList[2].studentmarks = marks;

            // Act
            studentsToVerify.AddRecord(studentsToCompare.studList[0].studentname, studentsToCompare.studList[0].studentmarks);
            studentsToVerify.AddRecord(studentsToCompare.studList[1].studentname, studentsToCompare.studList[1].studentmarks);
            studentsToVerify.AddRecord(studentsToCompare.studList[2].studentname, studentsToCompare.studList[2].studentmarks);

            // Asserts
            for (int i = 0; i < studentsToVerify.MaxStudents; i++)
            {
                Assert.AreEqual(studentsToCompare.studList[i].studentmarks, studentsToVerify.studList[i].studentmarks, "Incorrect marks of the " + i.ToString() + " student.");
            }
        }

        [TestMethod()]
        public void AddRecordTest_VerifyMultipleStudentsTotalmark()
        {
            // Arrange
            CStudents studentsToVerify = new CStudents();
            CStudents studentsToCompare = new CStudents();

            // The 1st student's info
            String name = "Ivan Ivanov";
            int[] marks = new int[] { 7, 6, 8, 9, 10 };
            int totalmark = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                totalmark += marks[i];
            }

            studentsToCompare.studList.Add(new CStudentDetails());
            studentsToCompare.studList[0].studentname = name;
            studentsToCompare.studList[0].studentmarks = marks;
            studentsToCompare.studList[0].totalmarks = totalmark;

            // The 2nd student's info
            name = "Kate Ivanova";
            marks = new int[] { 9, 9, 8, 10, 10 };
            totalmark = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                totalmark += marks[i];
            }

            studentsToCompare.studList.Add(new CStudentDetails());
            studentsToCompare.studList[1].studentname = name;
            studentsToCompare.studList[1].studentmarks = marks;
            studentsToCompare.studList[1].totalmarks = totalmark;

            // The 3rd student's info
            name = "Igor Petrov";
            marks = new int[] { 7, 5, 10, 9, 10 };
            totalmark = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                totalmark += marks[i];
            }

            studentsToCompare.studList.Add(new CStudentDetails());
            studentsToCompare.studList[2].studentname = name;
            studentsToCompare.studList[2].studentmarks = marks;
            studentsToCompare.studList[2].totalmarks = totalmark;

            // Act
            studentsToVerify.AddRecord(studentsToCompare.studList[0].studentname, studentsToCompare.studList[0].studentmarks);
            studentsToVerify.AddRecord(studentsToCompare.studList[1].studentname, studentsToCompare.studList[1].studentmarks);
            studentsToVerify.AddRecord(studentsToCompare.studList[2].studentname, studentsToCompare.studList[2].studentmarks);

            // Asserts
            for (int i = 0; i < studentsToVerify.MaxStudents; i++)
            {
                Assert.AreEqual(studentsToCompare.studList[i].totalmarks, studentsToVerify.studList[i].totalmarks, "Incorrect totalmarks of the " + i.ToString() + " student.");
            }
        }

        #endregion

        [TestCleanup]
        public void CleanupTest()
        {
            Console.Out.WriteLine("Complete test.");
        }
    }
}