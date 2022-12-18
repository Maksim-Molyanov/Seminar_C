// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = CreateRandom2DArray(m, n);

Print2DArray(array);

Console.Write("Среднее арифметическое = ");

PrintAvg(array);

void Print2DArray(int[,] array)
{
    for(var i = 0; i < array.GetLength(0); i++)
    {
        for(var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
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

void PrintAvg(int [,] array) 
{
    double sum = 0;
    double average = 0;
   for (var col = 0; col < array.GetLength(1); col++)
    {
        for (var row = 0; row < array.GetLength(0); row++)
        {
            sum = sum + array[row, col];
        }
        average = sum / array.GetLength(0);
        Console.Write(string.Format("{0:0.0} ", average));
        sum = 0;
    }
}