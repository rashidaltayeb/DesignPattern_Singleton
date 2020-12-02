using System;

namespace SingletonTest
{
    public class Singleton
    {
        private static int _counter;
        private static Singleton _singleton; //declare the instance of singleton class with null value  
        public static Singleton GeSingleton
        {
            get
            {
                if (_singleton != null) return _singleton;
                _singleton = new Singleton();
                return _singleton;
            }
        }
        private Singleton()
        {
            _counter++;
            Console.WriteLine(@"Index Of Object ={0}",_counter.ToString());
        }
        public void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}