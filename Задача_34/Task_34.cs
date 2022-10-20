// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] Array(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ChetNum(int[] array)
{
    int chet = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2 == 0))
        {
            chet++;
        }
    }
    Console.WriteLine($"Четных элементов в массиве -> {chet}");
}

Console.Write("Введите длину массива: ");
int x = int.Parse(Console.ReadLine()!);

int[] array = Array(x);
ChetNum(array);
Console.Write(String.Join(", ", array));