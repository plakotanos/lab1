namespace Lab1;

public static class Program
{
    public static void Main()
    {
        // Создаем одномерный массив
        int[] array = { 2, -5, 3, 1, -4, 0, 7, -2, 9, 8 }; 

        // Вычисляем минимальный по модулю элемент массива
        int minAbsValue = CalculateMinAbsValue(array);
        
        Console.WriteLine("Минимальный по модулю элемент: " + minAbsValue);

        // Вычисляем сумму модулей элементов массива, расположенных после первого элемента, равного нулю
        int sumAfterZero = CalculateSumAfterZero(array);
        Console.WriteLine("Сумма модулей элементов после первого нуля: " + sumAfterZero);

        // Преобразовываем массив так, чтобы в первой половине были элементы на четных позициях, а во второй - на нечетных
        int[] transformedArray = TransformArray(array);
        Console.WriteLine("Преобразованный массив:");
        foreach (int number in transformedArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Создаем матрицу 10x10 (замените на свою матрицу)
        int[,] matrix = new int[10, 10]
        {
            { 3, 2, 1, 1, 2, 3, 4, 5, 6, 7 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
            { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
            { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
            { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 },
            { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
            { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
            { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 },
            { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }
        };

        // Подсчитываем количество локальных минимумов в матрице
        int localMinCount = CalculateLocalMinCount(matrix);
        Console.WriteLine("Количество локальных минимумов в матрице: " + localMinCount);

        // Находим сумму модулей элементов, расположенных выше главной диагонали
        int sumAboveDiagonal = CalculateSumAboveDiagonal(matrix);
        Console.WriteLine("Сумма модулей элементов выше главной диагонали: " + sumAboveDiagonal);
    }
    
    public static int CalculateMinAbsValue(int[] array)
    {
        int result = int.MaxValue;
        foreach (int number in array)
        {
            int absValue = Math.Abs(number);
            if (absValue < result)
            {
                result = absValue;
            }
        }

        return result;
    }

    public static int CalculateSumAfterZero(int[] array)
    {
        int result = 0;
        bool zeroFound = false;
        foreach (int number in array)
        {
            if (zeroFound)
            {
                result += Math.Abs(number);
            }
            if (number == 0)
            {
                zeroFound = true;
            }
        }

        return result;
    }

    public static int[] TransformArray(int[] array)
    {
        int[] result = new int[array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                result[i / 2] = array[i];
            }
            else
            {
                result[array.Length / 2 + i / 2] = array[i];
            }
        }

        return result;
    }

    public static int CalculateLocalMinCount(int[,] matrix)
    {
        int result = 0;
        
        for (int i = 1; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < matrix.GetLength(1) - 1; j++)
            {
                int currentElement = matrix[i, j];
                int[] neighbors = {
                    matrix[i - 1, j - 1], matrix[i - 1, j], matrix[i - 1, j + 1],
                    matrix[i, j - 1], matrix[i, j + 1],
                    matrix[i + 1, j - 1], matrix[i + 1, j], matrix[i + 1, j + 1]
                };

                bool isLocalMin = true;
                foreach (int neighbor in neighbors)
                {
                    if (currentElement >= neighbor)
                    {
                        isLocalMin = false;
                        break;
                    }
                }

                if (isLocalMin)
                {
                    result++;
                }
            }
        }

        return result;
    }

    public static int CalculateSumAboveDiagonal(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            throw new ArgumentException("Matrix is not a square");
        }
        
        int size = matrix.GetLength(0);
        int result = 0;
        
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                result += Math.Abs(matrix[i, j]);
            }
        }

        return result;
    }
}
