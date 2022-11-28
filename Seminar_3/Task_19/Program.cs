Console.Clear();
Console.Write("Введите 5-ти значное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 99999 || n < 10000)
    {
    Console.Write("Вы ошиблись!\nВведите 5-ти значное число: ");
    n = Convert.ToInt32(Console.ReadLine());
    }
if (n / 10000 == n % 10 && (n % 10000) / 1000 == (n / 10) % 10)
    Console.Write("да");
else 
    Console.Write("нет");
