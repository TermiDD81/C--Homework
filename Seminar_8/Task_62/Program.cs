void DisplayArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            Console.Write($"{matrix[i, j]} \t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

void Main(string[] args)
    {
        Console.Write("Введите размер матрицы (1 цифру): ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        int[,] matrix = new int[n, n];
        int i = 0, j = 0;
        int value = 1;
        while (n != 0)
            {
                int k = 0;
                do { matrix[i, j++] = value++; } while (++k < n - 1);
                for (k = 0; k < n - 1; k++) matrix[i++, j] = value++;
                for (k = 0; k < n - 1; k++) matrix[i, j--] = value++;
                for (k = 0; k < n - 1; k++) matrix[i--, j] = value++;
                ++i; ++j; n = n < 2 ? 0 : n - 2;
            }
            DisplayArray(matrix);
            Console.WriteLine();
    }
Main(args);