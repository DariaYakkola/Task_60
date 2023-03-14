Console.Write("Введите количество строк для трехмерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для трехмерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину трехмерного массива: ");
int depth = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = new int[rows, cols, depth];
/// <summary>
/// Метод, который создает трехмерный массив целых чисел из неповторяющихся рандомных чисел от 1 до 50
/// </summary>
/// <param name="array3D">Трехмерный массив целых чисел</param>
void GetArray3D(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number = 0;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(1, 50);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(1, 50);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
/// <summary>
/// Метод, который печатает трехмерный массив целых чисел
/// </summary>
/// <param name="array3D">Трехмерный массив целых чисел</param>
void PrintArray3D (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $" {array3D[i,j,k]} ({i}, {j}, {k}); ");
      }
      Console.WriteLine();
    }
  }
}
GetArray3D(array3D);
PrintArray3D(array3D);