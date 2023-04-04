// Напишите программу, которая заполнит спирально массив 4 на 4.

void WriteMatrix(char[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    for (int j = 0; j < matrix.GetLength(0); j++) System.Console.Write($"{matrix[j,i]}\t");
    System.Console.WriteLine();
  }
}
char[,] FillingSquareMatrixWithCheerfulSpiral(int size)
{
  string text = "Весёлая Спираль! ";
  int TextIndexNumber = 0;
  char[,] matrix = new char[size,size];
  int x = -1;
  int y = 0;
  int[] directionXAndY = new int[] {1, 0, -1, 0};
  int indexOfdirectionXAndY = 0;
  int xChange = directionXAndY[(0 + indexOfdirectionXAndY)%4];
  int yChange = directionXAndY[(3 + indexOfdirectionXAndY)%4];
  for (int limit = matrix.GetLength(0); limit > 0; limit = limit - 1 + Math.Abs(xChange))
  {
    for (int counter = 0; counter < limit; counter++)
    {
      x+=xChange;
      y+=yChange;
      matrix[x,y] = text[TextIndexNumber%text.Length];
      TextIndexNumber++;
    }
    indexOfdirectionXAndY++;
    xChange = directionXAndY[(0 + indexOfdirectionXAndY)%4];
    yChange = directionXAndY[(3 + indexOfdirectionXAndY)%4];
  }
  return matrix;
}
System.Console.WriteLine("Введите длину стороны квадратной матрицы");
int size = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();
WriteMatrix(FillingSquareMatrixWithCheerfulSpiral(size));