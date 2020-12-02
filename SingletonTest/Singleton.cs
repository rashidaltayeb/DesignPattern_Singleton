using System;

namespace SingletonTest
{
    public sealed class Singleton
    {
        private static int _counter; //count number of the all instance that was created
        private static Singleton _singleton; //declare the instance of singleton class with null value 
        // here check the instance is null or not
        public static Singleton GeSingleton
        {
            get
            {
                if (_singleton != null) return _singleton;
                _singleton = new Singleton();
                return _singleton;
            }
        }
        // Declare a private constructor 
        private Singleton()
        {
            _counter++;
            Console.WriteLine(@"Index Of Object ={0}",_counter.ToString());
        }
        // PrintMessage is a method jsut return string value
        public void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
