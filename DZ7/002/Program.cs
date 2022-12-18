// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);

Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine());
row--;
col--;
if(row >= array.GetLength(0) || col >= array.GetLength(1) || row < 0 || col < 0)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine($"Найден элемент: {array[row,col]}");
}

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
