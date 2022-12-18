// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] arrayA = CreateRandom2DArray(m, n);
int[,] arrayB = CreateRandom2DArray(m, n);
Print2DArray(arrayA);
Console.WriteLine();
Print2DArray(arrayB);
Console.WriteLine();

int[,] prodMatrix = CalcMatrixProduct(arrayA, arrayB);
Print2DArray(prodMatrix);

void Print2DArray(int[,] array)
{
    for(var i = 0; i < array.GetLength(0); i++)
    {
        for(var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandom2DArray(int CoutOfRows, int contOfColumns)
{
    Random random = new Random();
    int[,] array = new int[CoutOfRows, contOfColumns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(10);
        }
    }
    return array;
}

int[,] CalcMatrixProduct (int[,]matrixA,int[,]matrixB)
{
    int row = matrixA.GetLength(0);
    int col = matrixB.GetLength(1);
    int [,] ProdMatrix = new int [row, col];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        
         for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                for (int n = 0; n < matrixB.GetLength(0); n++)
                {
                    ProdMatrix[i,j] += matrixA[i,n] * matrixB[n,j]; 
                }
            }
    }
    return ProdMatrix;
}

