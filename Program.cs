using System;
using Math;
namespace JenkinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMaths mymath = new MyMaths();
            int a = mymath.Add(2, 3);
            int b = mymath.Multiply(3, 5);
            Console.WriteLine($"{a}....{b}");
        }
    }
}
