using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBuilder.Classes
{
    class CodeFellows
    {
        public List<StaffMember> Instructors { get; set; }
        public List<Student> Students { get; set; }
        public List<Cohort> Classes { get; set; }

        public CodeFellows()
        {
            Instructors = new List<StaffMember>();
            Students = new List<Student>();
            Classes = new List<Cohort>();
        }

        public void OpenClass(string subject, int level, string instructor)
        {
            string[] instructorname = instructor.Split(new char[] { ' ' });
            foreach(StaffMember staffMember in Instructors)
            {
                if (instructorname[0] == staffMember.FirstName &&
                    instructorname[instructorname.Length - 1] == staffMember.LastName)
                {

                    Cohort newClass = new Cohort(subject, level);
                    newClass.Instructors.Add(staffMember);
                    Classes.Add(newClass);
                    Console.WriteLine($"{subject} {level} is open for students!");

                }
                else
                {
                    Console.WriteLine($"No instructor was found while trying to open class {subject} {level}.");
                }
            }
        }

        public void NewStudent(string firstname, string lastname, string email, string phonenumber)
        {
            Students.Add(new Student(firstname, lastname, email, phonenumber));
        }

        public void NewStaff(string firstname, string lastname, string email, string phonenumber, string jobtitle)
        {
            Instructors.Add(new StaffMember(firstname, lastname, email, phonenumber, jobtitle));
        }
    }
}
