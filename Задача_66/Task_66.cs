// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int CountSum(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    else
    return end + CountSum(start, end - 1);
}

Console.Write("Ввведите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Ввведите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write(CountSum(m, n));