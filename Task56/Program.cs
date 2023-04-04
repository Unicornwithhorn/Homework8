// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int RowWithMinSumNumbers (int[,] matrix)
{
  int minvalue = 0;
  int rowNumberWithMinSum = 1;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) sum += matrix[i,j];
    if (j == 0) minvalue = sum;
    else
      if (sum < minvalue)
      {
        minvalue = sum;
        rowNumberWithMinSum = j + 1;
      }
  }
  return rowNumberWithMinSum;
}

System.Console.WriteLine("Введите ширину и высоту матрицы");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = CreateMassive(size[0],size[1]);
System.Console.WriteLine();
WriteMatrix(matrix);
System.Console.WriteLine();
int rowWithMinSum = RowWithMinSumNumbers(matrix);
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов - {rowWithMinSum}");
