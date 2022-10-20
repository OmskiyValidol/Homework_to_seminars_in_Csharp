// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] Array(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 100);
    }
    return array;
}

void Summ(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
}

Console.Write("Введите длину массива: ");
int x = int.Parse(Console.ReadLine()!);

int[] array = Array(x);
Summ(array);
Console.Write(String.Join(", ", array));