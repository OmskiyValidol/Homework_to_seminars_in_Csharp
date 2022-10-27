// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void AverageSumm(int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j ++)    
    {
        double summ = 0;                     
        for (int i = 0; i < array.GetLength(0); i ++)      
        {
            summ += array[i, j];
        }
        double result = summ / array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} = {result}");
    }
}                                

int [,] array = new int [4,5];
FillArray(array);
PrintArray(array);
AverageSumm(array);