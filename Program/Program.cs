using System;
using MyLibrary;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            // Тестирование методов void
            myClass.Method1();
            myClass.Method2();

            // Тестирование методов с возвращаемыми значениями
            int result1 = myClass.Method3();
            string result2 = myClass.Method4();
            bool result3 = myClass.Method5();

            Console.WriteLine($"Method3: {result1}");
            Console.WriteLine($"Method4: {result2}");
            Console.WriteLine($"Method5: {result3}");
        }
    }
}
