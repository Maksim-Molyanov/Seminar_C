// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] myArr = CreateRandomArray(size);

PrintArray(myArr);

Console.Write($"Количество чисел больше 0 = {CountGreateZero(myArr)}");

int[] CreateRandomArray(int size)
{
int[] myArr = new int[size];
    for (int i = 0; i < myArr.Length; i++)
    {
        Console.Write("Заполните массив: ");
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
    Console.WriteLine();
}

int CountGreateZero(int [] arr) 
{
    int counter = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}