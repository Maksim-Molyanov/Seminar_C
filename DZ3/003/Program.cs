// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
// Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int size = int.Parse(Console.ReadLine());
int[] numbers = new int [size];

SetCubeOfNumbers(numbers, size);

PrintArray(numbers);

void SetCubeOfNumbers(int[] arr, int size)
{
    for (int i = 1; i <= size; i++)
    {
        arr[i - 1] = i * i * i; 
    }
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine(arr[i]);
    }
}