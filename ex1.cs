// : Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int a = 0; a < matr.GetLength(1)-1; a++)
            {
                if(matr[i,a] < matr[i,a+1])
                {
                    int sort = matr[i,a+1];
                    matr[i, a+1] = matr[i,a];
                    matr[i,a] = sort;
                }
            }
        }
    }
}



    System.Console.WriteLine("Введите количество строк");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов");
    int j = Convert.ToInt32(Console.ReadLine());
    int[,] num = new int [n,j];

   
FillArray(num);
 Print(num);
 SortArray(num);
 Console.WriteLine();
Print(num);