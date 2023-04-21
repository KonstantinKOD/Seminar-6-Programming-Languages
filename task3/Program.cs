// программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int a = ReadInt("a number > 0");
Binar(a);

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) && number > 0)
    {
        System.Console.WriteLine("It's not that");
    }
    return number;
}

void Binar(int number)
{
    string line = string.Empty;
    while(number > 0)
    {
        line = line + (number % 2).ToString();
        number /=2;
    }
//System.Console.WriteLine(line);
string temp = string.Empty;
for (int i = 0; i < line.Length; i++)
    {
        temp += line[line.Length - 1 - i];
    }
    System.Console.WriteLine(temp);
}