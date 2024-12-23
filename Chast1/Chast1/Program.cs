using System;

namespace Chast1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                ShowMenu();
                int action = GetUser Choice(); // Исправлено имя метода

                Console.Clear(); // Очистка консоли

                switch (action)
                {
                    case 1:
                        ShowAverageCalculatorTask();
                        AverageCalculator();
                        break;
                    case 2:
                        ShowCalculatorTask();
                        Calculator();
                        break;
                    case 3:
                        ShowTemperatureConverterTask();
                        TemperatureConverter();
                        break;
                    case 4:
                        ShowFileNameExtractorTask();
                        FileNameExtractor();
                        break;
                    case 5:
                        ShowLongestWordFinderTask();
                        LongestWordFinder();
                        break;
                    case 6:
                        ShowArrayMultiplierTask();
                        ArrayMultiplier();
                        break;
                    case 7:
                        ShowMinMaxFinderTask();
                        MinMaxFinder();
                        break;
                    case 8:
                        ShowNumberPyramidTask();
                        NumberPyramid();
                        break;
                    case 9:
                        Console.WriteLine("Выход из программы.");
                        return; // Завершение программы
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                        break;
                }

                // Сообщение о завершении задачи
                Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
                Console.ReadKey();
                Console.Clear(); // Очистка консоли перед повторным отображением меню
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Нахождение среднего значения четырех чисел");
            Console.WriteLine("2. Калькулятор");
            Console.WriteLine("3. Конвертация температуры");
            Console.WriteLine("4. Определение имени файла по пути");
            Console.WriteLine("5. Нахождение самого длинного слова в предложении");
            Console.WriteLine("6. Перемножение двух массивов значений");
            Console.WriteLine("7. Нахождение максимального и минимального числа из пяти введенных");
            Console.WriteLine("8. Вывод 'пирамиды' из чисел");
            Console.WriteLine("9. Выход");
        }

        static int GetUser Choice() // Исправлено имя метода
        {
            Console.Write("Введите номер действия: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice)) // Используем TryParse
            {
                Console.Write("Неверный ввод. Пожалуйста, введите номер действия: ");
            }
            return choice;
        }

        // Пример метода для вычисления среднего значения
        static void AverageCalculator()
        {
            Console.WriteLine("Введите четыре числа:");
            double num1 = GetDoubleInput();
            double num2 = GetDoubleInput();
            double num3 = GetDoubleInput();
            double num4 = GetDoubleInput();
            double average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"Среднее значение: {average}");
        }

        static double GetDoubleInput()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Неверный ввод. Пожалуйста, введите число: ");
            }
            return number;
        }

        // Заглушки для остальных методов
        static void ShowAverageCalculatorTask() => Console.WriteLine("Задача: Нахождение среднего значения четырех чисел.");
        static void ShowCalculatorTask() => Console.WriteLine("Задача: Калькулятор.");
        static void ShowTemperatureConverterTask() => Console.WriteLine("Задача: Конвертация температуры.");
        static void ShowFileNameExtractorTask() => Console.WriteLine("Задача: Определение имени файла по пути.");
        static void ShowLongestWordFinderTask() => Console.WriteLine("Задача: Нахождение самого длинного слова в предложении.");
        static void ShowArrayMultiplierTask() => Console.WriteLine("Задача: Перемножение двух массивов значений.");
        static void ShowMinMaxFinderTask() => Console.WriteLine("Задача: Нахождение максимального и минимального числа из пяти введенных.");
        static void ShowNumberPyramidTask() => Console.WriteLine("Задача: Вывод 'пирамиды' из чисел.");

        // Заглушки для других методов
        static void Calculator() { /* Реализация калькулятора */ }
        static void TemperatureConverter() { /* Реализация конвертации температуры */ }
        static void FileNameExtractor() { /* Реализация извлечения имени файла */ }
        static void LongestWordFinder() { /* Реализация нахождения самого длинного слова */ }
        static void ArrayMultiplier() { /* Реализация перемножения массивов */ }
        static void MinMaxFinder() { /* Реализация нахождения максимума и минимума */ }
        static void NumberPyramid() { /* Реализация вывода пирамиды чисел */ }
    }
}
