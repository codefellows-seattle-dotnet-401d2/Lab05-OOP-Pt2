using System;

namespace CodeFellows
{
    // Abstraction
    public abstract class CodeFellowsClass
    {
        public static void Main(string[] args)
        {
          
        }

        public bool Classrooms { get; set; }

        public bool Kitchen { get; set; }

        public bool Community { get; set; }

        public void Learn()
        {
            Console.WriteLine("So much learning at Code Fellows");
        }

        public void PreReq()
        {
            Console.WriteLine("Passed Admissions Test");
        }

        public void Schedule()
        {
            Console.WriteLine("Morning Lecture");
        }

    }
}
