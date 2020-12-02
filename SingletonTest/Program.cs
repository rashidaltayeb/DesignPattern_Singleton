using System;

namespace SingletonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton empolyee = Singleton.GeSingleton;
            empolyee.PrintMessage("From Employee");
            Singleton student = Singleton.GeSingleton;
            student.PrintMessage("From student");
        }
    }
}
