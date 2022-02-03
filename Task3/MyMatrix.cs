namespace Task3
{
    internal class MyMatrix
    {
        private int[,] array;

        public MyMatrix(uint rows, uint columns)
        {
            array = new int[rows, columns];
        }

        public int this[uint rows, uint columns]
        {
            get { return array[rows, columns]; }
            set { array[rows, columns] = value; }
        }

        //Отображение любой матрицы
        public static void ShowInfo(int[,] arrayToShow)
        {
            if (arrayToShow != null)
            {
                Console.WriteLine("\nМатрица:");
                for (int i = 0; i < arrayToShow.GetLength(0); i++)
                {
                    string line = "";
                    for (int j = 0; j < arrayToShow.GetLength(1); j++)
                    {
                        line += arrayToShow[i, j].ToString() + " ";
                    }
                    Console.WriteLine(line);
                }     
            }
            else
            {
                ClassException.ExceptionMessage("Массив не заполнен!");
            }
        }
        //Отображение матрицы экземпляра
        public void Show()
        {
            ShowInfo(array);
        }

        //Создаем новый массив нового порядка на основе старого
        public int[,] ChangeArray(uint newRows, uint newColumns)
        {
            int[,] newArray = new int[newRows, newColumns];
            //Если размеры массивов совпадают, то просто заполняем новый массив старыми значениями
            if ((newRows == array.GetLength(0)) && (newColumns == array.GetLength(1)))
            {
                this.FillArray(ref newArray, 0, array.GetLength(0), 0, array.GetLength(1));
            }

            //Если размер нового массива больше старого, то заполняем новый массив старыми значениями
            //в пределах размеров старого, а остальное заполняем нулями
            else if ((newRows > array.GetLength(0)) && (newColumns > array.GetLength(1)))
            {
                this.FillArray(ref newArray, 0, array.GetLength(0), 0, array.GetLength(1));

                this.FillArrayZero(ref newArray, array.GetLength(0), newArray.GetLength(0), array.GetLength(1), newArray.GetLength(1));
            }

            //Если строк у нового массива меньше или равно, чем у старого, а столбцов больше и равно,
            //то заполняем новый массив старыми значениями в пределах размеров старого, а остальное заполняем нулями
            else if ((newRows <= array.GetLength(0)) && (newColumns >= array.GetLength(1)))
            {
                this.FillArray(ref newArray, 0, newArray.GetLength(0), 0, array.GetLength(1));
                if (newColumns > array.GetLength(1))
                    this.FillArrayZero(ref newArray, 0, newArray.GetLength(0), array.GetLength(1), newArray.GetLength(1));
            }

            //Если размер нового массива меньше старого, то заполняем новый массив старыми значениями
            //в пределах размеров нового (обрезаем старый)
            else if ((newRows < array.GetLength(0)) && (newColumns < array.GetLength(1)))
            {
                this.FillArray(ref newArray, 0, newArray.GetLength(0), 0, newArray.GetLength(1));                
            }

            //Если столбцов у нового массива меньше или равно, чем у старого, а строк больше или равно,
            //то заполняем новый массив старыми значениями в пределах размеров старого, а остальное заполняем нулями
            else if ((newRows >= array.GetLength(0)) && (newColumns <= array.GetLength(1)))
            {
                this.FillArray(ref newArray, 0, array.GetLength(0), 0, newArray.GetLength(1));
                if (newRows > array.GetLength(0))
                    this.FillArrayZero(ref newArray, array.GetLength(0), newArray.GetLength(0), 0, newArray.GetLength(1));
            }
            return newArray;
        }

        //Заполнение нового массива значениями старого массива
        void FillArray(ref int[,] arrayToFill, int rowStart, int rowEnd, int colStart, int colEnd)
        {
            for (int i = rowStart; i < rowEnd; i++)
            {
                for (int j = colStart; j < colEnd; j++)
                {
                    arrayToFill[i, j] = this.array[i, j];
                }
            }
        }

        //Заполнение нового массива нулями
        void FillArrayZero(ref int[,] arrayToFill, int rowStart, int rowEnd, int colStart, int colEnd)
        {
            for (int i = rowStart; i < rowEnd; i++)
            {
                for (int j = colStart; j < colEnd; j++)
                {
                    Random ran = new Random();                    
                    arrayToFill[i, j] = 0;
                }
            }
        }

        //Заполнение массива рандомными значениями 
        public void FillArrayRandom()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Random ran = new Random();
                    array[i, j] = ran.Next(1,10);
                }
            }
        }
    }
}
