using System;
using System.Threading.Tasks;

namespace SingletonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintEmpolyeeMessage(),
                () => PrintStudentMessage());
        }
        private static void PrintStudentMessage()
        {
            Singleton student = Singleton.GeSingleton;
            student.PrintMessage("From student");
        }

        private static void PrintEmpolyeeMessage()
        {
            Singleton empolyee = Singleton.GeSingleton;
            empolyee.PrintMessage("From Employee");
        }
    }
}
