// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Не использовать готовые методы Min и Max

// [3 7 22 2 78] -> 76


Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
double [] myArr = CreateRandomArray(size);

PrintArray(myArr);

Console.Write(string.Format("Разница min и max элементов массива  = {0:0.00}", CalcDiffMinMax(myArr)));

double[] CreateRandomArray(int size)
{
Random rand = new Random();
double[] myArr = new double[size];
    for (int i = 0; i < myArr.Length; i++)
    {
        myArr[i] = rand.NextDouble()*100;
    }
    return myArr;
}

void PrintArray(double [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(string.Format("{0:0.00} ", array[i]));
    }
    Console.WriteLine();
}

double CalcDiffMinMax(double [] arr) 
{
    double min = arr[0];
    double max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
       if (arr[i] < min)
       {
            min = arr[i];
       }
       if (arr[i] > max)
       {
            max = arr[i];
       }
    }
    return max - min;
}