// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction(int start, int end)
{
    if (start == 0)
        return end + 1;
    if (start > 0 && end == 0)
        return AckermanFunction(start - 1, 1);
    else
        return AckermanFunction(start - 1, AckermanFunction(start, end - 1));
}

Console.Write("Ввведите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Ввведите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write(AckermanFunction(m, n));