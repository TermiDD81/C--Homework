Console.Clear();
Console.Write("Введите число 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
    Console.Write("max = " + n1);
else 
    Console.Write("max = " + n2);