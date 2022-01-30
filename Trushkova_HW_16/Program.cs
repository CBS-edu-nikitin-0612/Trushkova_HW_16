// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Teacher!");

while (true)
{
    try
    {
        Console.WriteLine("Введите число элементов массива:");
        uint lengthArray = Convert.ToUInt32(Console.ReadLine());
        if (lengthArray > 0)
        {
            int[] array = new int[lengthArray];
            Console.WriteLine("Введите элементы массива:\n");
            for (int i = 0; i < lengthArray; i++)
            {
                Console.Write($"Элемент {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Наибольшее значение массива равно {array.Max()}");
            Console.WriteLine($"Наименьшее значение массива равно {array.Min()}");
            Console.WriteLine($"Общая сумма всех элементов массива равна {array.Sum()}");
            Console.WriteLine($"Среднее арифметическое всех элементов массива равно {array.Average()}");
            Console.WriteLine($"Все нечетные значения массива равны {string.Join(", ", array.Where(x => OddNumbers(x)))}\n");
        }
        else
        {
            ExceptionMessage("Надо ввести натуральное число.\n");
        }
    }
    catch (Exception ex)
    {
        switch (ex.GetType().ToString())
        {
            case "System.OverflowException":
                ExceptionMessage($"Слишком большое число. Введите от 1 до {UInt32.MaxValue}\n");
                break;

            case "System.FormatException":
                ExceptionMessage("Вы ввели не целочисленное число.\n");
                break;

            default:
                ExceptionMessage(ex.GetType().ToString());
                break;
        }
    }
}

static bool OddNumbers(int num)
{
    if (num % 2 == 0)
        return false;
    else
        return true;
}

static void ExceptionMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.Gray;
}