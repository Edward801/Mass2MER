// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.



int[,] Create2DArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }

    return array;
}

void Print2DArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}

int[,] myArray = Create2DArray(5, 5, 0, 9);
Print2DArray(myArray);



int numRows = myArray.GetLength(0);
int numColumns = myArray.GetLength(1);
int minSum = int.MaxValue;
int minSumRowIndex = -1;

for (int i = 0; i < numRows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < numColumns; j++)
        {
            rowSum += myArray[i, j];
        }

        if (rowSum < minSum)
        {
                minSum = rowSum;
                minSumRowIndex = i;
        }
    }

    if (minSumRowIndex != -1)
    {
        Console.WriteLine("Строка с наименьшей суммой элементов: ");
        for (int j = 0; j < numColumns; j++)
        {
            Console.Write(myArray[minSumRowIndex, j] + " ");
        }
    }

    else
    {
        Console.WriteLine("Массив пуст");
    }
    
