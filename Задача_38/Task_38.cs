// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double Max (double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double Min (double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] Array(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-100, 100) + rand.NextDouble();
    }
    return array;
}

Console.Write("Введите длину массива: ");
int x = int.Parse(Console.ReadLine()!);

double[] array = Array(x);
Console.WriteLine(String.Join(", ", array));

double max = Max(array);
double min = Min(array);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");