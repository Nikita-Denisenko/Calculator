Dictionary<string, Func<double, double,  double>> operations = new()
{
    ["+"] = (a, b) => a + b,
    ["-"] = (a, b) => a - b,
    ["*"] = (a, b) => a * b,
    ["/"] = (a, b) => a / b,
};

var userString = Console.ReadLine();

while (true)
{
    
    if (!string.IsNullOrEmpty(userString))
    {
        break;
    }
    
    userString = Console.ReadLine();

}

var expression = userString.Split(" ");
var s1 = expression[0]; 
var s2 = expression[2];
if (!(double.TryParse(s1, out var x) && double.TryParse(s2, out var y)))
{
    Console.WriteLine("Ошибочный ввод!");
    return;
}

var operation = expression[1];

if (!operations.Keys.ToArray().Contains(operation))
{
    Console.WriteLine("Ошибочный ввод!");
    return;
}

if (operation == "/" && y == 0)
{
    Console.WriteLine("На ноль делить нельзя!");
    return;
}

double result = operations[operation](x, y);

Console.WriteLine(result); 