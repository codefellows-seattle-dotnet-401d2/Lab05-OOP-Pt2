using System;
using Xunit;
using SchoolBuilder;
using SchoolBuilder.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        CodeFellows codefellows = new CodeFellows();

        //Create new staff
        codefellows.NewStaff("Sam", "Hamm", "SamHamm@Codefellows.Edu", "555-555-5555", "Master Laptop Jockey");
        codefellows.NewStaff("Allie", "Grampa", "AllieG@Codefellows.Edu", "555-555-5555", "Brainstructor");
        codefellows.NewStaff("Amanda", "Iverson", "IAmanda@Codefellows.Edu", "555-555-5555", "Microsoft Wizard");
        codefellows.NewStaff("Austin", "Cohrs", "ACohrs@Codefellows.Edu", "555-555-5555", "Giant Nerd");

        //Create students
        codefellows.NewStudent("Dustin", "Mundy", "Dustin.A.Mundy@gmail.com", "555-555-5555");
        codefellows.NewStudent("Matt", "Iwicky", "MattMan@gmail.com", "555-555-5555");
        codefellows.NewStudent("Andre", "Ibarra", "QueensBridgeKid@gmail.com", "555-555-5555");
        codefellows.NewStudent("Jeff", "Martinez", "JeffM@Gmail.com", "555-555-5555");
        codefellows.NewStudent("Ariel", "Pedraza", "APedraza@yahoo.com", "555-555-5555");
        codefellows.NewStudent("Luay", "Younus", "LuayYounus@Luay.Younus", "555-555-5555");
        codefellows.NewStudent("Zachary", "Johnson", "ZachJons@Reptar.net", "555-555-5555");

        //Create cohorts
        codefellows.OpenClass("JavaScript", 301, "Sam Hamm");
        codefellows.OpenClass("JavaScript", 201, "Allie Grampa");
        codefellows.OpenClass("ASP.NET", 401, "Amanda Iverson");

        //Add students to JavaScript 301
        codefellows.Classes[0].NewStudent(codefellows.Students[0]);
        codefellows.Classes[0].NewStudent(codefellows.Students[1]);
        codefellows.Classes[0].NewStudent(codefellows.Students[2]);
        codefellows.Classes[0].NewStudent(codefellows.Students[3]);
        codefellows.Classes[0].NewStudent(codefellows.Students[4]);

        //Add students to ASP.NET 401
        codefellows.Classes[2].NewStudent(codefellows.Students[0]);
        codefellows.Classes[2].NewStudent(codefellows.Students[1]);
        codefellows.Classes[2].NewStudent(codefellows.Students[2]);
        codefellows.Classes[2].NewStudent(codefellows.Students[3]);
        codefellows.Classes[2].NewStudent(codefellows.Students[4]);
        codefellows.Classes[2].NewStudent(codefellows.Students[5]);
        codefellows.Classes[2].NewStudent(codefellows.Students[6]);

        [Fact]
        public void AllInstructorsCount()
        {
            Assert.Equal(4, codefellows.Instructors.Count);
        }

        [Fact]
        public void AllStudentsCount()
        {
            Assert.Equal(7, codefellows.Students.Count);
        }

        [Fact]
        public void Cohort0Students()
        {
            Assert.Equal(5, codefellows.Classes[0].Students.Count);
        }

        [Fact]
        public void Cohort0Instructor()
        {
            Assert.Equal("Amanda", codefellows.Classes[2].Instructors[0].FirstName);
        }
    }
}
