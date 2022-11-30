// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int day = int.Parse(Console.ReadLine());

if (day <= 7 && day >= 1)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Число не является днем недели");
}