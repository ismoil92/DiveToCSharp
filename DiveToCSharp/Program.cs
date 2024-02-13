using DiveToCSharp;

Console.Write("Введите два число:");
string input = Console.ReadLine()!;
var array = input.Split(' ');
Console.WriteLine();
Console.WriteLine("Введите арифметические операции +, -, *, /");
Console.Write("Введите:");
char oper = char.Parse(Console.ReadLine()!);
switch(oper)
{
    case '+':
       Console.WriteLine($"Сумма :{Calculate.Sum(double.Parse(array[0]),
           double.Parse(array[1]))}");
        break;
    case '-':
        Console.WriteLine($"Вычитание :{Calculate.Subtract(double.Parse(array[0]),
           double.Parse(array[1]))}");
        break;
    case '*':
        Console.WriteLine($"Умножение :{Calculate.Multiply(double.Parse(array[0]),
           double.Parse(array[1]))}");
        break;
    default:
        Console.WriteLine($"Деление :{Calculate.Divide(double.Parse(array[0]),
           double.Parse(array[1]))}");
        break;
}