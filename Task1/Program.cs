//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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



Console.WriteLine("Введите номер строки Nrow (начиная с 0): ");
int Nrow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца Ncolumn (начиная с 0): ");
int Ncolumn = Convert.ToInt32(Console.ReadLine());

if(Nrow >= 0 && Nrow < myArray.GetLength(0) && Ncolumn >= 0 && Ncolumn < myArray.GetLength(1))
{
    Console.WriteLine("Значение элемента массива по указанному индексу: " + myArray[Nrow, Ncolumn]);
}
else 
{
    Console.WriteLine("Нет указанного элемента в массиве. Убедитесь, что ввели индексы начиная с 0 и не выходящие за границы массива.");
}