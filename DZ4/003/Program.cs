// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

int[] myArr = CreateArray(size);
PrintArray(myArr);

int[] CreateArray(int size)
{
int[] myArr = new int[size];
    for (int i = 0; i < myArr.Length; i++)
    {
        myArr[i] = int.Parse(Console.ReadLine());

    }
    return myArr;
}

void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}