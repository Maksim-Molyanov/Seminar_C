// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] myArr = CreateRandomArray(size);

PrintArray(myArr);

Console.Write($"Сумма чёных элементов массива  = {CalcSum(myArr)}");

int[] CreateRandomArray(int size)
{
Random rand = new Random();
int[] myArr = new int[size];
    for (int i = 0; i < myArr.Length; i++)
    {
        myArr[i] = rand.Next(-99, 100);
    }
    return myArr;
}

void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int CalcSum(int [] arr) 
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i+=2)
    {
        sum = sum + arr[i];
    }
    return sum;
}