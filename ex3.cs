// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray_1(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
       for (int j = 0; j < matr1.GetLength(1); j++)
       {
        matr1[i,j] = new Random().Next(1,10);
       } 
    }
}

void FillArray_2(int[,] matr2)
{
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
       for (int j = 0; j < matr2.GetLength(1); j++)
       {
        matr2[i,j] = new Random().Next(1,10);
       } 
    }
}

void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($" {matr [i, j]}");
        }
        Console.WriteLine();
    }
}

void Proiz(int [,] matr1, int [,] matr2, int [,] res)
{
    
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            int sum = 0;
           for (int k = 0; k < res.GetLength(1); k++)
           {
             
             sum += matr1[i,k] * matr2[k,j]; 
           } 
           res[i,j]=sum;
        }
    }

}



    System.Console.WriteLine("Введите количество строк первой матрицы");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов первой матрицы");
    int j = Convert.ToInt32(Console.ReadLine());
    int[,] num_1 = new int [n,j];

    System.Console.WriteLine("Введите количество строк второй матрицы");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов второй матрицы");
    int b = Convert.ToInt32(Console.ReadLine());
    int[,] num_2 = new int [a,b];

    int [,] res = new int [n,b];



FillArray_1(num_1);
FillArray_2(num_2);
 Print(num_1);
 Print(num_2);
Console.WriteLine();
Proiz(num_1, num_2, res);
Print(res);

