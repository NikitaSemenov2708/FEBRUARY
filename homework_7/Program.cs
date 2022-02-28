using System;
//Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.
 /*  void PrintArray(double[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i , j]}; ");
    }
   Console.WriteLine(); 
}
}
void FillArray(double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
          matr[i,j] = new Random().Next(1, 10)+ new Random().NextDouble() ;
      }
      
  }

}
double[,] matrix = new double [3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix); */

//Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.
/* void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i , j]}; ");
    }
   Console.WriteLine(); 
}
}
void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
          matr[i,j] = i+j ;
      }
      
  }

}
int[,] matrix = new int [4, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix); */

//Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

/* void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i , j]}; ");
    }
   Console.WriteLine(); 
}
}
void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
  {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
          matr[i,j] = new Random().Next(1, 10) ;
      }
      
  }

}

void ChangeArray(int[,] matr)
{
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
string result=string.Empty;
  for (int i = 0; i < matr.GetLength(0); i++)
  {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
          matr[i,j] = new Random().Next(1, 10);
          if (matr[i,j]==number)
          {
              result=result+$"{matr[i,j]}; ";
              Console.WriteLine(result);
          }
          
      }
      
  }
if (result==string.Empty)
          {
              Console.WriteLine("Такого числа нет");
          }
}
int[,] matrix = new int [4, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
ChangeArray(matrix);
PrintArray(matrix); */

//Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов