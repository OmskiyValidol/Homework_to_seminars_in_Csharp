// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] Array(string stringArray)
{
    string[] numbers = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}

int CountPos(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите числа через пробел: ");
string input = Console.ReadLine()!;
int[] numbersArray = Array(input);
int count = CountPos(numbersArray);
Console.Write($"Чисел больше нуля -> {count}");