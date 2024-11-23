using System;
using System.IO;
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

            // Тестирование метода чтения файла
            try
            {
                string fileContent = myClass.ReadFile("example.txt");
                Console.WriteLine("Содержимое файла: " + fileContent);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка: {e.Message}");
            }

            // Тестирование метода сортировки массива
            int[] array = { 5, 3, 8, 2, 1 };
            int[] sortedArray = myClass.SortArray(array);
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", sortedArray));

            // Ввод дат и вычисление разницы между ними
            DateTime date1, date2;

            while (true)
            {
                Console.WriteLine("Введите первую дату (в формате ГГГГ-ММ-ДД):");
                if (DateTime.TryParse(Console.ReadLine(), out date1))
                {
                    break;
                }
                Console.WriteLine("Неправильный формат даты. Пожалуйста, введите дату в формате ГГГГ-ММ-ДД.");
            }

            while (true)
            {
                Console.WriteLine("Введите вторую дату (в формате ГГГГ-ММ-ДД):");
                if (DateTime.TryParse(Console.ReadLine(), out date2))
                {
                    break;
                }
                Console.WriteLine("Неправильный формат даты. Пожалуйста, введите дату в формате ГГГГ-ММ-ДД.");
            }

            TimeSpan difference = myClass.CalculateDateDifference(date1, date2);
            Console.WriteLine($"Разница между датами: {difference.Days} дней");

            Console.WriteLine("Завершение работы программы.");
        }
    }
}
