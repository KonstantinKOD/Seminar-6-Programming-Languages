// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int [] CreateArray(int Length, int min, int max)
{
int [] numbers = new int [Length];

for (int i = 0; i < numbers.Length; i++)
{
numbers[i] = new Random().Next(min,max +1);
}
return numbers;
}

void PrintArray(int [] numbers)
{
System.Console.Write("[");
for (int i = 0; i < numbers.Length -1; i++)
{
System.Console.Write(numbers[i] + "; ");
}
System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}

int Num (string arg)
{
System.Console.WriteLine($"Введите {arg} ");
return int.Parse(System.Console.ReadLine());
}


int []NewNumbers(int [] numbers)
{
int [] NewNumbers = new int [numbers.Length];
for (int i = 0; i < NewNumbers.Length; i++)
{
NewNumbers[i] = numbers[i];
}
return NewNumbers;
}



int Length = Num("длину массива");
int min = Num("меньшее число");
int max = Num("максимальное число");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers);
int [] NewNumbe;