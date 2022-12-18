// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

double[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);

void Print2DArray(double[,] array)
{
    for(var i = 0; i < array.GetLength(0); i++)
    {
        for(var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:0.0} ", array[i,j]));
        }
        Console.WriteLine();
    }
}

double[,] CreateRandom2DArray(int CoutOfRows, int contOfColumns)
{
    Random random = new Random();
    double[,] array = new double[CoutOfRows, contOfColumns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.NextDouble()*(10+10)-10;
        }
    }
    return array;
}

