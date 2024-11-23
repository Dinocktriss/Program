using System;
using System.IO;
using System.Threading.Tasks;
using MyLibrary;

class Program
{
    static async Task Main(string[] args)
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

        // Тестирование асинхронного метода
        try
        {
            string fileContent = await myClass.ReadFileAsync("example.txt");
            Console.WriteLine("Содержимое файла: " + fileContent);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        // Тестирование метода сортировки массива
        int[] array = { 5, 3, 8, 2, 1 };
        int[] sortedArray = myClass.SortArray(array);
        Console.WriteLine("Отсортированный массив: " + string.Join(", ", sortedArray));

        // Тестирование метода вычисления разницы между датами
        DateTime date1 = new DateTime(2024, 1, 1);
        DateTime date2 = DateTime.Now;
        TimeSpan difference = myClass.CalculateDateDifference(date1, date2);
        Console.WriteLine($"Разница между датами: {difference.Days} дней");
    }
}
