int rec(int m, int n)
{
    if (m == n)
        return m;
    return rec(m, n - 1) + n;
}


Console.Clear();
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));