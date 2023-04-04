// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

void WriteMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
      if (matrix[j,i] == 0) System.Console.Write(" \t");
      else System.Console.Write($"{matrix[j,i]}\t");
    }
    System.Console.WriteLine();
  }
}

int[,] CreatePascalTriangle(int numbersOfRows)
{
  int[,] matrix = new int[2*numbersOfRows-1,numbersOfRows];
  matrix[numbersOfRows-1,0] = 1;
  matrix[0,numbersOfRows-1] = 1;
  matrix[2*numbersOfRows-2,numbersOfRows-1] = 1;
  for (int i = 1; i < numbersOfRows; i++)
    for (int j = 1; j < 2 * numbersOfRows - 2; j++) matrix[j,i]=matrix[j-1,i-1]+matrix[j+1,i-1];
  
  return matrix;
}

Console.WriteLine("Введите количество строк треугольника Паскаля");
int N = int.Parse(Console.ReadLine()!);
WriteMatrix(CreatePascalTriangle(N));
