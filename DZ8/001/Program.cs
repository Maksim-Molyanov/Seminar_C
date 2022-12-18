// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);
RowSort(array);
Console.WriteLine();
Print2DArray(array);

void Print2DArray(int[,] array)
{
    for(var i = 0; i < array.GetLength(0); i++)
    {
        for(var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandom2DArray(int CoutOfRows, int contOfColumns)
{
    Random random = new Random();
    int[,] array = new int[CoutOfRows, contOfColumns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(10);
        }
    }
    return array;
}

void RowSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        bool swapped = true;
        while (swapped)
        {
            swapped = false;
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if (array[i,j] < array[i,j +1])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                    swapped = true;

                }
            }
        }
    }
}