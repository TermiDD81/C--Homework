void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11); 
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
double[] array = new double[matrix.GetLength(1)];
for (int i = 0; i < matrix.GetLength(1); i++)
{   
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
        {
        sum += matrix [j, i];
        }
array[i] = Math.Round(sum / matrix.GetLength(0), 2);
}
Console.WriteLine("Среднее арифметическое столбцов:");
Console.WriteLine($"[{string.Join(",\t", array)}]");