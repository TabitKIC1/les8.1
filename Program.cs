// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
        matr[i,j] = new Random().Next(1,10);
       } 
    }
}

void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void MinSum (int[,] matr)
{
    int minstr = 0;
    int minsum = 0;
    int sumstr = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        minstr += matr[0, i];
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) sumstr += matr[i, j];
        if (sumstr < minstr)
        {
            minstr = sumstr;
            minsum = i;
        }
        sumstr = 0;
    }
    Console.Write($"{minsum + 1} строка");
}





    System.Console.WriteLine("Введите количество строк");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов");
    int j = Convert.ToInt32(Console.ReadLine());
    int[,] num = new int [n,j];

   
FillArray(num);
 Print(num);
 MinSum (num);
 Console.WriteLine();
Print(num);