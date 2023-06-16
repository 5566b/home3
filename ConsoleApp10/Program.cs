Console.WriteLine("enter ");
var num1 = (Console.ReadLine());


Console.WriteLine("Выберите операцию (+, -, *, /:");
string operation = Console.ReadLine();


Console.WriteLine("Введите второе число:");
double num2 = double.Parse(Console.ReadLine());

double result = 0;

switch (operation)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        result = num1 / num2;
        break;
    default:
        Console.WriteLine("Операция не распознана.");
        break;
}

Console.WriteLine("Результат: " + result);