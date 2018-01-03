using System;

namespace CodeFellows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student ariel = new Student("Seattle", "Ariel Pedraza", "pedrazaa2@gmail.com");
            _401NetCore dotnet401d2 = new _401NetCore("Seattle", 10, "d2");
            ariel.Enroll(dotnet401d2);
            Console.ReadLine();
        }
    }
}
