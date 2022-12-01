Console.Clear();
Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int s = 1;
int i = b;
while (i > 0)
{
    s = s * a;
    i--;
}
Console.WriteLine("А в степени В = ");
Console.WriteLine(s);