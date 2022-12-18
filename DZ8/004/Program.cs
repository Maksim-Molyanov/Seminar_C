// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите высоту: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите длину: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите глубину: ");
int d = int.Parse(Console.ReadLine());

int[,,] array = CreateRandom2DArray(m, n, d);
Print2DArray(array);


void Print2DArray(int[,,] array)
{
    for(var i = 0; i < array.GetLength(0); i++)
    {
        for(var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} [{i}, {j}, {k}] \t");
            }
        }
        Console.WriteLine();
    }
}

int[,,] CreateRandom2DArray(int CoutOfRows, int contOfColumns, int contOfDepth)
{
    Random random = new Random();
    int[,,] array = new int[CoutOfRows, contOfColumns, contOfDepth];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                int num = random.Next(10, 100);
                while(ConteinsNumber(num, array))
                {
                    num = random.Next(10, 100);
                }
                array[i,j,k] = num;
            }
        }
    }
    return array;
}

bool ConteinsNumber(int num, int[,,] array)
{
 for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                if(num == array[i,j,k])
                {
                    return true;
                }
            }
        }
    }
    return false;
}