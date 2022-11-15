// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void SortArray (int [,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j ++)
    {
        for (int i = 0; i < matr.GetLength(0); i ++)
        {
            int max = matr [i,j];
            for (int k = j + 1; k < matr.GetLength(1); k ++)
            {
                if (matr [i, k] >= max)
                {
                    max = matr [i, k];
                    int temp = matr [i, j];
                    matr [i, j] = matr [i, k];
                    matr [i, k] = temp;
                } 
            }
        }
    }
} 
            
int [,] Matrix = new int [4, 4];
Console.WriteLine("Сгенерированный массив: ");
FillArray(Matrix);
PrintArray(Matrix);
Console.WriteLine("Сортированный массив: ");
SortArray(Matrix);
PrintArray(Matrix);