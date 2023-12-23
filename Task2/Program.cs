// Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

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

int numberOfRows = myArray.GetLength(0);
        int numberOfColumns = myArray.GetLength(1);

        for (int col = 0; col < numberOfColumns; col++)
        {
            int temp = myArray[0, col];
            myArray[0, col] = myArray[numberOfRows - 1, col];
            myArray[numberOfRows - 1, col] = temp;
        }

        // Выводим измененный массив
        Console.WriteLine("Массив с поменяными строками:");
        Print2DArray(myArray);
