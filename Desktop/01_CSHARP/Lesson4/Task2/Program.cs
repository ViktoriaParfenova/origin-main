﻿/*

int[,] CreateMatrix(int rowCount, int columCount)
{
    int[,] matrix = new int[rowCount, columCount];//3строки и 5 столбцов,мы обозначили его память
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }

    }
    return matrix;
}

int[,] matrix = CreateMatrix(3, 4);
foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
   {
        Console.Write($"{e} ");
    }

}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
        return false;
    
}
int GetSumOfDigits(int value);
{
    int sum = 0;
    while(value > 0)
    {
       sum += value % 10;
       value /= 10;
    }
    return sum;
}
System.Console.WriteLine();
*/

string str = "Hello world!";
System.Console.WriteLine(str[3]);