Console.Clear();
Console.Write("Введите 3-х значное число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 100 || a > 999)
{
    Console.WriteLine("Вы ошиблись!\nВведите 3-х значное число: ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a > 99 && a < 1000)
    Console.Write((a / 10) % 10);