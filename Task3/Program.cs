// See https://aka.ms/new-console-template for more information
using Task3;

Console.WriteLine("Hello, Teacher!");

//Создание и вывод на экран исходной матрицы
(uint, uint) rowsAndColumns = ReadColRow("исходной");
MyMatrix array = new MyMatrix(rowsAndColumns.Item1, rowsAndColumns.Item2);
array.FillArrayRandom();
array.Show();

//Создание и вывод на экран производной матрицы
while (true)
{
    (uint, uint) newRowsAndColumns = ReadColRow("производной");
    int[,] newArray = array.ChangeArray(newRowsAndColumns.Item1, newRowsAndColumns.Item2);
    MyMatrix.ShowInfo(newArray);
}

//Получение от пользователя числа строк и столбцов для матрицы
static (uint, uint) ReadColRow(string name)
{
    uint rowArray;
    uint colArray;

    while (true)
    {
        try
        {
            Console.WriteLine($"\nВведите число строк {name} матрицы:");
            rowArray = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Введите число столбцов {name} матрицы:");
            colArray = Convert.ToUInt32(Console.ReadLine());

            if ((rowArray > 0) && (colArray > 0))
            {
                break;
            }
            else
            {
                ClassException.ExceptionMessage("Надо ввести для строк и столбцов натуральное число.\n");
            }
        }
        catch (Exception ex)
        {
            ClassException.ExceptionProcessing(ex);
        }
    }
    return (rowArray, colArray);
}
