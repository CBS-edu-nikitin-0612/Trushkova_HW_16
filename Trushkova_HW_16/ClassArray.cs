namespace Task2
{
    internal class ClassArray
    {
        private int[] array;

        public ClassArray (uint length)
        {
            array = new int[length];
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public void ShowInfo()
        {
            if (array != null)
            {
                Console.WriteLine($"Наибольшее значение массива равно {array.Max()}");
                Console.WriteLine($"Наименьшее значение массива равно {array.Min()}");
                Console.WriteLine($"Общая сумма всех элементов массива равна {array.Sum()}");
                Console.WriteLine($"Среднее арифметическое всех элементов массива равно {array.Average()}");
                Console.WriteLine($"Все нечетные значения массива равны {string.Join(", ", array.Where(x => OddNumbers(x)))}\n");
            }
            else
            {
                ClassException.ExceptionMessage("Массив не заполнен!");
            }
        }

        static bool OddNumbers(int num)
        {
            if (num % 2 == 0)
                return false;
            else
                return true;
        }
    }
}
