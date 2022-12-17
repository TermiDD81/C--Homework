void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j; // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.Write("Введите позицию строки: ");
int selectI = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int selectJ = Convert.ToInt32(Console.ReadLine());
if (selectI > matrix.GetLength(0) || selectJ > matrix.GetLength(1))
    Console.WriteLine("Такой позиции в массиве нет");
else Console.WriteLine($"Значение элемента {matrix[selectI - 1, selectJ - 1]}");

