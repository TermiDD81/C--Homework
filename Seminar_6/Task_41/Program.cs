Console.Clear();
Console.Write("Сколько чисел будете вводить?: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[m];
for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Введите число {i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
        count++;
}
Console.WriteLine($"Введенные числа: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество чисел > 0 = {count}");