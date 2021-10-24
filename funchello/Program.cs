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

        static void Calc(int arg){
            arg += 10;
            Console.WriteLine($"{arg}");

        }
        static void Main(string[] args)
        {
            int val = 10;
            Calc(val);
            Console.WriteLine($"{val}");
            PutYourName();
            Console.WriteLine("Hello World!");
            myFunc();
        }
    }
}
