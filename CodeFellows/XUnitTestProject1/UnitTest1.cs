using System;
using Xunit;
using CodeFellows;
using CodeFellows.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        // Test for Inheritance
        [Fact]
        public void CheckCSharpInheritance()
        {
            Assert.Equal("Today, we learned Javascript", CSharp.TeachStudents());
        }

        [Fact]
        public void CheckJavscriptInheritance()
        {
            Assert.Equal("Used as admission to the next class", Javascript.PassFinal());
        }




    }
}
