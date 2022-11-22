Console.Clear();
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && b > c) 
    Console.Write("max = " + a);
if (b > a && a > c) 
    Console.Write("max = " + b);
if (c > b && b > a) 
    Console.Write("max = " + c);