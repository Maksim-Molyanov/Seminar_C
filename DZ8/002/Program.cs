// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);
PrintRowMinSum(array);

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

void PrintRowMinSum(int[,] array)
{
    int minRowNumber = 0;
    int minsum = int.MaxValue;
    for (var i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (var j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(sum < minsum)
        {
            minsum = sum;
            minRowNumber = i;
            minRowNumber++;
        }
    }
    Console.WriteLine($"Наименьшая суммой элементов = {minsum}. Строка: {minRowNumber}");
}
