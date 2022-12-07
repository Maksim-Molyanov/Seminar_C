// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num = int.Parse(Console.ReadLine());

int sum = SumOfDigits(num);
Console.WriteLine(sum);


int SumOfDigits(int num)
{
    int sum = 0;
    while(num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}