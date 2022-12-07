// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A в натуральную степень B. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow()


int num = int.Parse(Console.ReadLine());
int pow = int.Parse(Console.ReadLine());

int result = CalcPowV1(num, pow);
Console.WriteLine($"Способ первый {result}");

result = CalcPowV2(num, pow);
Console.WriteLine($"Способ второй {result}");

int CalcPowV1(int a, int b)                
{
    int result = 1;
    for(int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

int CalcPowV2(int a, int b)
{
    int result = 1;
    while(b != 0)
    {
        if(b % 2 == 0)
        {
           b = b / 2;
           a = a * a;
        }
        else
        {
            b--;
            result = result * a;
        }
    }
    return result;
}