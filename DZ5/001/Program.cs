// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




int size = int.Parse(Console.ReadLine());
int[] myArr = CreateRandomArray(size);

PrintArray(myArr);

Console.Write($"Количество чётных чисел в массиве = {CountEven(myArr)}");

int[] CreateRandomArray(int size)
{
Random rand = new Random();
int[] myArr = new int[size];
    for (int i = 0; i < myArr.Length; i++)
    {
        myArr[i] = rand.Next(100, 1000);
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

int CountEven(int [] arr) 
{
    int counter = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}