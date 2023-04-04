// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int[,,] CreateMassive(int x, int y, int z)
{
  int[,,] matrix = new int[x,y,z];
  for (int k = 0; k < z; k++)
    for (int i = 0; i < y; i++)
      for (int j = 0; j < x; j++) matrix[j,i,k] = new Random().Next(10,100);
    return matrix;
}

void WriteMatrix(int[,,] matrix)
{
  for  (int k = 0; k < matrix.GetLength(2); k++)
  {
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
      for (int j = 0; j < matrix.GetLength(0); j++) System.Console.Write($"{matrix[j,i,k]} {j},{i},{k}\t");
      System.Console.WriteLine();
    }
  }
}

System.Console.WriteLine("Введите ширину высоту и глубину(?) матрицы.");

int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
System.Console.WriteLine();
int[,,] matrix = CreateMassive(size[0], size[1], size[2]);
WriteMatrix(matrix);

