// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Изменение C
// Изменение D
// Изменение E
// Изменение R
int[,] CreateMassive(int x, int y)
{
  int[,] matrix = new int[x,y];
  for (int i = 0; i < y; i++)
    for (int j = 0; j < x; j++) matrix[j,i] = new Random().Next(0,10);
  return matrix;
}

void WriteMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    for (int j = 0; j < matrix.GetLength(0); j++) System.Console.Write($"{matrix[j,i]}\t");
    System.Console.WriteLine();
  }
}


void DescendingOrderInCurrentRow(int[,] matrix, int row)
{
  int[] rowInOrder = new int[matrix.GetLength(0)];
  int[] busyNumbers = new int[matrix.GetLength(0)];
  for (int j = 0; j < matrix.GetLength(0); j++)
  {
    int max = -10000;
    int maxIndex = -10000;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      if (matrix[i,row] > max && busyNumbers[i] == 0)
      {
        max = matrix[i,row];
        maxIndex = i;
      }
    }
    rowInOrder[j] = max;
    busyNumbers[maxIndex] = 1;
  }
  for (int i = 0; i < matrix.GetLength(0); i++) matrix[i,row] = rowInOrder[i];
}

void DescendingOrder(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
  DescendingOrderInCurrentRow(matrix, i);
  }
}

System.Console.WriteLine("Введите ширину и высоту матрицы");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = CreateMassive(size[0],size[1]);
WriteMatrix(matrix);
DescendingOrder(matrix);
System.Console.WriteLine();
WriteMatrix(matrix);
