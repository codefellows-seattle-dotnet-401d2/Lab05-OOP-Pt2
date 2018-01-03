using System;
using Xunit;
using CodeFellows;

namespace XUnitTestCodeFellows
{
    public class UnitTest1
    {
        [Fact]
        public void TestStudentEnroll()
        {
            Student ariel = new Student("Seattle", "Ariel Pedraza", "pedrazaa2@gmail.com");
            _401NetCore dotnet401d2 = new _401NetCore("Seattle", 10, "d2");
            Assert.True(ariel.Enroll(dotnet401d2));
        }

        [Fact]
        public void TestStudentSubmitAssign()
        {
            Student ariel = new Student("Seattle", "Ariel Pedraza", "pedrazaa2@gmail.com");
            Assert.Equal("Ariel Pedraza submitted Lab 01", ariel.SubmitAssignment("Lab 01"));
        }

        [Fact]
        public void TestStudentStandUp()
        {
            Student ariel = new Student("Seattle", "Ariel Pedraza", "pedrazaa2@gmail.com");
            Assert.True(ariel.AttendStandUp());
        }

        [Fact]
        public void TestStudentTravel()
        {
            Student ariel = new Student("Seattle", "Ariel Pedraza", "pedrazaa2@gmail.com");
            Assert.True(ariel.TravelToCampus());
        }

        [Fact]
        public void TestStudentLecture()
        {
            Student ariel = new Student("Seattle", "Ariel Pedraza", "pedrazaa2@gmail.com");
            Assert.True(ariel.GoToLecture());
        }
    }
}
