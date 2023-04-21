// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int ReadInt(string arg)
{
    System.Console.Write($"Введите число: ");
    return int.Parse(Console.ReadLine());
}

int N = ReadInt("N");

int [] Array(int Length)
{
    int [] numbers = new int[Length];
    numbers[0] = 0;
    numbers[1] = 1;
    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i-1] + numbers[i-2];
    }
    return numbers;
}

System.Console.WriteLine(string.Join(", ", Array(N) ));