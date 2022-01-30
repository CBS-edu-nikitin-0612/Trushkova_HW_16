// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, Teacher!");

while (true)
{
    try
    {
        Console.WriteLine("Введите число элементов массива:");
        uint lengthArray = Convert.ToUInt32(Console.ReadLine());
        if (lengthArray > 0)
        {
            ClassArray array = new (lengthArray);
            Console.WriteLine("Введите элементы массива:\n");
            for (int i = 0; i < lengthArray; i++)
            {
                Console.Write($"Элемент {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }   
            array.ShowInfo();
        }
        else
        {
            ClassException.ExceptionMessage("Надо ввести натуральное число.\n");
        }        
    }
    catch (Exception ex)
    {
        ClassException.ExceptionProcessing(ex);
    }
}


