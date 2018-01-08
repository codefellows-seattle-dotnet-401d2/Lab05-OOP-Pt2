using System;
using SchoolBuilder.Classes;

namespace SchoolBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFellows CodeFellows = new CodeFellows();

            CodeFellows.NewStaff("Sam", "Hamm", "SamHamm@Codefellows.Edu", "555-555-5555","Master Laptop Jockey");
            CodeFellows.NewStaff("Allie", "Grampa", "AllieG@Codefellows.Edu", "555-555-5555", "Brainstructor");
            CodeFellows.NewStaff("Amanda", "Iverson", "IAmanda@Codefellows.Edu", "555-555-5555", "Microsoft Wizard");
            CodeFellows.NewStaff("Austin", "Cohrs", "ACohrs@Codefellows.Edu", "555-555-5555", "Giant Nerd");

            CodeFellows.NewStudent("Dustin", "Mundy", "Dustin.A.Mundy@gmail.com", "555-555-5555");
            CodeFellows.NewStudent("Matt", "Iwicky", "MattMan@gmail.com", "555-555-5555");
            CodeFellows.NewStudent("Andre", "Ibarra", "QueensBridgeKid@gmail.com", "555-555-5555");
            CodeFellows.NewStudent("Jeff", "Martinez", "JeffM@Gmail.com", "555-555-5555");
            CodeFellows.NewStudent("Ariel", "Pedraza", "APedraza@yahoo.com", "555-555-5555");
            CodeFellows.NewStudent("Luay", "Younus", "LuayYounus@Luay.Younus", "555-555-5555");
            CodeFellows.NewStudent("Zachary", "Johnson", "ZachJons@Reptar.net", "555-555-5555");

            CodeFellows.OpenClass("JavaScript", 301, "Sam Hamm");
            CodeFellows.OpenClass("JavaScript", 201, "Allie Grampa");
            CodeFellows.OpenClass("ASP.NET", 401, "Amanda Iverson");

            CodeFellows.Classes[0].NewStudent(CodeFellows.Students[0]);
            CodeFellows.Classes[0].NewStudent(CodeFellows.Students[1]);
            CodeFellows.Classes[0].NewStudent(CodeFellows.Students[2]);
            CodeFellows.Classes[0].NewStudent(CodeFellows.Students[3]);
            CodeFellows.Classes[0].NewStudent(CodeFellows.Students[4]);

            CodeFellows.Classes[2].NewStudent(CodeFellows.Students[0]);
            CodeFellows.Classes[2].NewStudent(CodeFellows.Students[1]);
            CodeFellows.Classes[2].NewStudent(CodeFellows.Students[2]);
            CodeFellows.Classes[2].NewStudent(CodeFellows.Students[3]);
            CodeFellows.Classes[2].NewStudent(CodeFellows.Students[4]);
            CodeFellows.Classes[2].NewStudent(CodeFellows.Students[5]);
            CodeFellows.Classes[2].NewStudent(CodeFellows.Students[6]);


            DisplayCohort(0);
            DisplayCohort(2);

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine()
        }

        public static void DisplayCohort(int cohort)
        {
            CodeFellows CodeFellows = new CodeFellows();
            Console.WriteLine(CodeFellows.Classes[cohort].ClassName);
            Console.WriteLine("Instructors:");
            Console.WriteLine(CodeFellows.Classes[cohort].Instructors);
            Console.WriteLine("Students:");
            Console.WriteLine(CodeFellows.Classes[cohort].Students);
        }
    }
}
