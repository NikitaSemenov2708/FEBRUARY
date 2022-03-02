//Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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

 int[,] SortArray(int[,] matr)
{
    int temp=0;
    for (int k = 0; k <= (matr.GetLength(0) * matr.GetLength(1)); k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1) - 1; j++)
            {
                if (matr[i, j] < matr[i, j + 1])
                {
                    temp = matr[i, j];
                    matr[i, j] = matr[i, j + 1];
                    matr[i, j + 1] = temp;
                }
            }
        }
    }
    return matr;
}

int[,] matrix = new int [4, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
SortArray(matrix); 
PrintArray(matrix); */
//Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

/*  void PrintArray(int[,] matr)
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
int result=0;
int count=0;
void ChangeArray(int[,] matr)
{ 
    count=matr.GetLength(0)*9;
    for (int i = 0; i < matr.GetLength(0); i++)
  {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
          result= result+matr[i,j];
          
      }
       if (result<count)
     {
         count=result;
         result=0;
     } 
   result=0;
  }
  
}

 int result2=0;
void Change2Array(int[,] matr)
{  
    for (int i = 0; i < matr.GetLength(0); i++)
  {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
          result2= result2+matr[i,j];
          
      }
      if (result2==count)
      {
         Console.WriteLine ($"Cтрока с наименьшей суммой элементов = {i}");
      }
      result2=0;
  }
}  
int[,] matrix = new int [6, 2];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
ChangeArray(matrix);
Console.WriteLine($"НАименьшая сумма элеменотов = {count}");
Change2Array(matrix);  */

//Задача 61: Найти произведение двух матриц. (не решена)

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
void FillArrayMatrix1(int[,] matr1)
{
for (int i = 0; i < matr1.GetLength(0); i++)
  {
      for (int j = 0; j < matr1.GetLength(1); j++)
      {
          matr1[i,j] = new Random().Next(1, 10) ;
      }
      
  }
}
void FillArrayMatrix2(int[,] matr2)
{
for (int i = 0; i < matr2.GetLength(0); i++)
  {
      for (int j = 0; j < matr2.GetLength(1); j++)
      {
          matr2[i,j] = new Random().Next(1, 10) ;
      }
      
  }
}
void MultiplicationArray(int[,] matr1,int[,] matr2, int matr3)
{
matr3 =0;
for (int i = 0; i < matr1.GetLength(0); i++)
{
    for (int j = 0; j < matr1.GetLength(1); j++)
    {
        matr3= (matr1[i,j]*matr2[j,i]);
        Console.Write(matr3);
    }
Console.WriteLine();
}

}

int[,] matrix = new int [6, 2];
PrintArray(matrix);
FillArrayMatrix1(matrix);
FillArrayMatrix2(matrix);
Console.WriteLine();
MultiplicationArray(FillArrayMatrix1(matrix),FillArrayMatrix2(matrix),0); */
//Задача 63: Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента