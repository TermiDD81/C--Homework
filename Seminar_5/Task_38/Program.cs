void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100)/10.0;
}

double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= max)
            max = array[i];
            else if (array[i] <= max && min > array[i]) 
            min = array[i];
        }
    double diff = max - min;
    Console.WriteLine($"Max = {max}, Min = {min}");
    return diff;
}

Console.Clear();
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine(DiffMaxMin(array));
