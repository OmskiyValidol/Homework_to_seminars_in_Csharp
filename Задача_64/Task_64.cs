// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetPrint(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    else
    {
        Console.Write($"{GetPrint(start, end + 1)}, ");
        return end;
    }
}

Console.Write("Ввведите число N: ");
int start = int.Parse(Console.ReadLine()!);
int end = 1;
Console.Write(GetPrint(start, end));