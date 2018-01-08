using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBuilder.Classes
{
    public class Cohort
    {
        public string ClassName { get => Subject + Level; }
        public string Subject { get; set; }
        public int Level { get; set; }
        public List<StaffMember> Instructors { get; set; }
        public List<Student> Students { get; set; }

        public Cohort(string subject, int level)
        {
            Subject = subject;
            Level = level;
            Instructors = new List<StaffMember>();
            Students = new List<Student>();
        }

        public void NewStudent(Student student)
        {
            Students.Add(student);
        }

        public void NewStaff(StaffMember instructor)
        {
            Instructors.Add(instructor);
        }
    }
}
