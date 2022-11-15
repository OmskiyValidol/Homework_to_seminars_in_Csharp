// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray3D(int m, int n, int p, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}
int[] BinToSingleArray(int[,,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)* array.GetLength(2)];
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                result[n++] = array[i, j, k];
            }
        }
    }
    return result;
}
void PrintArray3D(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)

        for (int j = 0; j < inArray.GetLength(1); j++)
            for (int k = 0; k < inArray.GetLength(2); k++)
           {
            Console.Write($"{inArray[i, j, k]}\t ");
            Console.Write($"({i}, {j}, {k})\t ");
        }
        Console.WriteLine();
}
bool ScanArrayToOriginality(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] == array[j])
            {
                return true;
            }
        }
    }
    return false;
}

Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int colunms = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество страниц в массиве: ");
int pages = int.Parse(Console.ReadLine()!);

int[,,] userArray = GetArray3D(rows, colunms, pages, 0, 100);
int[] arrayInspect = BinToSingleArray(userArray);

if (ScanArrayToOriginality(arrayInspect))
{
    PrintArray3D(userArray);
    Console.WriteLine();
    Console.Write("Элементы не уникальны!");
}
else
{
    Console.WriteLine();
    PrintArray3D(userArray);
    Console.WriteLine();
}