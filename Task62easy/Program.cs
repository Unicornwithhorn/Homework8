// Напишите программу, которая заполнит спирально массив 4 на 4.

void WriteMatrix(string[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    for (int j = 0; j < matrix.GetLength(0); j++) System.Console.Write($"{matrix[j,i]}\t");
    System.Console.WriteLine();
  }
}

string[,] matrix = new string[4,4];
matrix[0,0] = "01";
matrix[1,0] = "02";
matrix[2,0] = "03";
matrix[3,0] = "04";
matrix[3,1] = "05";
matrix[3,2] = "06";
matrix[3,3] = "07";
matrix[2,3] = "08";
matrix[1,3] = "09";
matrix[0,3] = "10";
matrix[0,2] = "11";
matrix[0,1] = "12";
matrix[1,1] = "13";
matrix[2,1] = "14";
matrix[2,2] = "15";
matrix[1,2] = "16";

WriteMatrix(matrix);