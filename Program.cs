// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] FillArray()
{
    Console.WriteLine("Input rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input col: ");
    int col = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minmin meaning: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minmin meaning: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    double[,] Matrix = new double[rows, col];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
        }
    }
    return Matrix;
}

void Print2DArray(double[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round((Matrix[i, j]), 2) + " "}");
        }
        Console.WriteLine(" ");
    }
}

double[,] Array = FillArray();
Print2DArray(Array);
*/

//----------------------------------------------------------------------------


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> числа с такими индексами в массиве нет

/*
int [,] Fill2DArray ()
{
    Console.WriteLine("Input rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input col: ");
    int col = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minmin meaning: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minmin meaning: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int [,] Matrix = new int [rows, col];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return Matrix;
}

void Print2DArray (int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++) 
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

int SearchIndexArray(int [,] Array)
{
    Console.WriteLine("Input Search rows: ");
    int searchRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input Search col: ");
    int searchCol = Convert.ToInt32(Console.ReadLine());
    int result = -2;
    for (int i = 0; i < Array.GetLength(0); i++)   
         for (int j = 0; j < Array.GetLength(1); j++)
         if (i == searchRows && j == searchCol)
            result = Array[i, j];
    return result;
}

int [,] Matr = Fill2DArray();
Print2DArray(Matr);
Console.Write ( "Искомое значение: " + SearchIndexArray(Matr));
*/

//----------------------------------------------------------------------------


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] Fill2DArray(int rows, int col, int minValue, int maxValue)
{

    int[,] Matrix = new int[rows, col];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return Matrix;
}

void Print2DArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

double ArifmetikMean(int[,] Array, int i)
{
    double arifmetik = 0;
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            arifmetik = arifmetik + Array[j, i];
        }
    return arifmetik;
}

Console.WriteLine("Input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input col: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minmin meaning: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minmin meaning: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] Matr = Fill2DArray(rows, col, minValue, maxValue);
Print2DArray(Matr);
Console.WriteLine(" ");
Console.Write("Среднее арифметическое столбцов: ");

for (int i = 0; i < Matr.GetLength(1); i++)
    Console.Write(Math.Round((ArifmetikMean(Matr, i)/ rows), 1) + "; ");
