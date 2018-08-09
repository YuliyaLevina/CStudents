using System;
using STUDENTS_MARKS_REPORT;
using Xunit;

namespace XUnitTests
{
    public class XnitCStudentsTests
    {
        //[Fact]
        [Theory]
        [InlineData(0,20)]
        [InlineData(100,-10)]
        public void TestMethod1(int a, int b)
        {
            int a1 = a;
            int b1 = b;
        }
    }
}
