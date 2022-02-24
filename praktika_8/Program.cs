//написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
/* using System;
void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i , j]}");
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
          matr[i,j] = new Random().Next(1, 10);
      }
      
  }
}
void ChangeArray(int[,] matr)
{
  int n = matr.GetLength(0);
  
   for (int i = 0; i < matr.GetLength(0); i++)
  {
      for (int j = i+1; j < matr.GetLength(1); j++)
      {
          int temp = matr[i,j];
          matr[i,j]=matr[j,i];
          matr[j,i]=temp;
            
      }
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
//Написать программу, которая обменивает элементы первой строки и последней строки
/* void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i , j]}");
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
          matr[i,j] = new Random().Next(1, 10);
      }
      
  }
}
void ChangeArray(int[,] matr)
{
  int n = matr.GetLength(0);
  
   for (int i = 0; i < 1; i++)
  {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
          int temp=matr[i,j];
          matr[i,j]=matr[n-1,j];
            matr[n-1,j]=temp;
            
      }
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