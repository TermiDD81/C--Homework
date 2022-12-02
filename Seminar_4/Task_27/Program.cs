// Вариант через цикл
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n > 0)
    {
    sum = sum + (n % 10);
    n = n / 10;
    }
Console.WriteLine(sum);

// Вариант через массив (но получился костыль)
// Console.Clear();
// Console.WriteLine("Введите число:");
// string n = Console.ReadLine();
// int[] array = new int[n.Length];
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
//     {
//     array[i] = n[i];
//     sum = sum + n[i] - 48;
//     }
// Console.WriteLine(sum);

