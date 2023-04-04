// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixProduct (int[,] matrix1, int[,] matrix2)
{
  int sizeNewMatrix = 0;
  //new int();
  if (matrix1.GetLength(0) > matrix1.GetLength(1)) sizeNewMatrix = matrix1.GetLength(0);
  else sizeNewMatrix = matrix1.GetLength(1);

  int[,] matrixProduct = new int[sizeNewMatrix,sizeNewMatrix];
  for (int j = 0; j < sizeNewMatrix; j++)
    for (int i = 0; i <sizeNewMatrix; i++)
      for (int k = 0; k < matrix1.GetLength(0); k++) matrixProduct[i,j] += matrix1[k,j]*matrix2[i,k];
  return matrixProduct;
}

System.Console.WriteLine("Введите ширину и высоту первой матрицы. Они же будут являться высотой и шириной второй матрицы соответственно");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] firstMatrix = CreateMassive(size[0],size[1]);
int[,] secondMatrix = CreateMassive(size[1],size[0]);
System.Console.WriteLine();
WriteMatrix(firstMatrix);
System.Console.WriteLine();
WriteMatrix(secondMatrix);
System.Console.WriteLine();
int[,] Product = MatrixProduct(firstMatrix,secondMatrix);
System.Console.WriteLine($"Произведение данных матриц:");
WriteMatrix(Product);


