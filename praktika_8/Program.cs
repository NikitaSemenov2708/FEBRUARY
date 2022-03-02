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

//сколько раз и какое число встречалось в двумерном массиве заполлненым от 1 до 9

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
int count0=0;
int count1=0;
int count2=0;
int count3=0;
int count4=0;
int count5=0;
int count6=0;
int count7=0;
int count8=0;
void CheckNumber(int[,] matr, int[] arr)

{

for (int i = 0; i < matr.GetLength(0); i++)
  {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
          
          for (int k = 0; k < arr.GetLength(0); k++)
          {
               if (matr[i,j]==arr[3])
              {
                  
                Console.WriteLine($"Число {matr[i,j]} {arr[0]} встречается {count0} раз") ;
                count0++;
              } 
              
              
             
          }
          //count=0;
      }
      
  }
  
}

int[,] matrix = new int [4, 4];
int [] arr1 =  new int [9] {1,2,3,4,5,6,7,8,9};
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
CheckNumber(matrix,arr1); */