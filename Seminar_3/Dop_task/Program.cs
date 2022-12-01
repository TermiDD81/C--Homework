Console.Clear();
void FillArray(int[] gryadki)
{
    Console.WriteLine("Введите количество грядок: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int length = gryadki.Length;
    int index = 0;
    while (index < length)
    {
        gryadki[index] = new Random().Next(1, 10);
        index++;
    }
}