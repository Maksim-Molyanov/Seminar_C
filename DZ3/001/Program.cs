// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль. Не использовать String!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num = int.Parse(Console.ReadLine());
if (num >= 10000 && num < 100000)
{
    int firstDigit = num / 10000;
    int secondDigit = num /1000 % 10;
    int fourthDigit= num / 10 % 10;
    int fifthDigit = num % 10;
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
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
    Console.WriteLine("Число не пятизначное");
}