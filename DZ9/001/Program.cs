// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
printNum(n);

void printNum(int i)
{
    if(i < 1)
    {
        return;
    }
    Console.WriteLine(i);
    printNum(i -1);
}
