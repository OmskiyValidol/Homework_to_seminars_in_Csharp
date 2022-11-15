// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt (string message)                      
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintArray (int [,] matr)                         
{
    for (int i = 0; i < matr.GetLength(0); i ++)
    {
        for (int j = 0; j < matr.GetLength(1); j ++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int [,] matr)                          
{
    for (int i = 0; i < matr.GetLength(0); i ++)
    {
        for (int j = 0; j < matr.GetLength(1); j ++)
        {
            matr[i, j] = new Random().Next(0, 5);
        }
    }
}

bool ValidateMatr (int [,] Matr1, int [,] Matr2)
{
    if (Matr1.GetLength(1) != Matr2.GetLength(0))
    {
        return false;
    }
    return true;
}

int [,] MultiplicationMatr (int [,] Matr1, int [,] Matr2)
{       
    int [,] Matr3 = new int [Matr1.GetLength(0), Matr2.GetLength(1)];
    for (int i = 0; i < Matr1.GetLength(0); i ++)
    {
        for (int j = 0; j < Matr2.GetLength(1); j ++)
        {
            Matr3 [i,j] = 0;
            for (int n = 0; n < Matr1.GetLength(1); n++ )
            {
                Matr3[i, j] += Matr1[i, n] * Matr2[n, j];
            }
        }
    }
    return Matr3;
}

int i = Prompt("Введите количество строк первой матрицы: ");
int j = Prompt("Введите количество столбцов первой матрицы: ");
int [,] Arr1 = new int [i,j];
int m = Prompt("Введите количество строк второй матрицы: ");
int n = Prompt("Введите количество столбцов второй матрицы: ");
int [,] Arr2 = new int [m,n];

Console.WriteLine();
Console.WriteLine("Задана первая матрица: ");
FillArray(Arr1);
PrintArray(Arr1);
Console.WriteLine("Задана вторая матрица: ");
FillArray(Arr2);
PrintArray(Arr2);
Console.WriteLine();
if (!ValidateMatr(Arr1, Arr2))
{
    Console.WriteLine("Произведение матриц невозможно, количество столбцов первой матрицы должно быть равно количеству строк второй.");
}
else
{
    Console.WriteLine("Получим произведение двух матриц: ");
    PrintArray(MultiplicationMatr(Arr1, Arr2));
}
Console.WriteLine();