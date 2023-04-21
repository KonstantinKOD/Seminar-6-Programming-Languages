// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int a = ReadInt("длина стороны А");
int b = ReadInt("длина стороны Б");
int c = ReadInt("длина стороны В");
Treangle(a, b, c);

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Введите {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) && number > 0)
    {
        System.Console.WriteLine("Не корректный ввод.");
    }
    return number;
}

void Treangle(int a, int b, int c)
{
    if( a + b > c && b + c > a && c + a > b)
    {
        System.Console.WriteLine("Треугольник с такими сторонами может существовать");
    }
    else
    {
        System.Console.WriteLine("Треугольник с такими сторонами не может существовать");
    }
}