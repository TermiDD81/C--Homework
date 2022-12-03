Console.Clear();
Console.WriteLine("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите число {i+1}");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число для сдвига (положительное - вправо, отрицательное влево): ");
int s = Convert.ToInt32(Console.ReadLine());
if (s > 0)
    {
        while (s > 0)
        {
        int tmp = array[n-1];
        for (int i = n - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
            }
        array[0] = tmp;
        s = s - 1;
        }
    }
else
    {
        while (s < 0)
        {
        int tmp = array[0]; 
        { 
        for(int i = 0; i < n-1; i++)
            array[i] = array[i+1];
        }
        array[n-1] = tmp;
        s = s + 1;
        }
    }
Console.WriteLine($"[{string.Join(", ", array)}]");