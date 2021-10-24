using System;

namespace funchello
{
    class Program
    {
        static void PutYourName(){
            Console.WriteLine("Put your name");
            Console.ReadLine();
        }
        static void myFunc(){
            Console.WriteLine("Hello How Are you?");
        }
        static void Main(string[] args)
        {
            PutYourName();
            Console.WriteLine("Hello World!");
            myFunc();
        }
    }
}
