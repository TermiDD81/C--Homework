Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (a >= i)
{
    Console.Write(i + " ");
    i = i + 2;
}