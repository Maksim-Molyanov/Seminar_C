// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




int n = 4;
int[,] array = new int[n, n];
int i = 0, j = 0;
int value = 1;

while (n != 0)
{
    int k = 0;
    do
    {
        array[i, j++] = value++;
    }
    while (++k < n - 1);
    for (k = 0; k < n - 1; k++) array[i++, j] = value++;
    for (k = 0; k < n - 1; k++) array[i, j--] = value++;
    for (k = 0; k < n - 1; k++) array[i--, j] = value++;

    ++i;
    ++j;
    if(n<2)
    {
        n = 0;
    }
    else
    {
        n = n - 2;
    }
}

PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write("{0,3} ", array[i, j]);
        Console.WriteLine();
    }
}

