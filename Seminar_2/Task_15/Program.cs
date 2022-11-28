Console.Clear();
Console.Write("Введите день недели (число): ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 7)
{
    Console.WriteLine("Вы ошиблись!\nВведите день недели (число): ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a == 6 || a == 7)
    Console.Write("Да");
else 
    Console.Write("Нет");