Dictionary<string, Func<double, double,  double>> doOperation = new()
{
    ["+"] = (a, b) => a + b,
    ["-"] = (a, b) => a - b,
    ["*"] = (a, b) => a * b,
    ["/"] = (a, b) => a / b,
};

void Main()
{
    var expression = GetUserExpression();
    
    while (!IsValid(expression))
    {
        expression = GetUserExpression();
    }

    var answer = Calculate(expression);

    Console.WriteLine(answer);
} 

string[] GetUserExpression()
{
    while (true)
    {
        var userString = Console.ReadLine();
        
        if (string.IsNullOrEmpty(userString))
        {
            continue;
        }

        return userString.Split(" ");
    }
}

bool IsValid(string[] input)
{
    for (var i = 0; i < input.Length; i++)
    {
        var current = input[i];
        
        if (i % 2 == 0)
        {
            if (!double.TryParse(current, out var _))
            {
                return false;
            }

            if (i > 0 && current == "0" && input[i - 1] == "/")
            {
                Console.WriteLine("На ноль делить нельзя!");
                return false;
            }
            continue;
        }

        if (!doOperation.ContainsKey(current))
        {
            return false;
        }
    }
    return true;
}

double Calculate(string[] expression)
{
    double result = 0;

    for (var i = 1; i < expression.Length; i += 2)
    {
        var operation = expression[i];
        var nextNumber = double.Parse(expression[i + 1]);
        var lastNumber = result;
        
        if (i == 1)
        {
            lastNumber = double.Parse(expression[i - 1]);
        }

        result = doOperation[operation](lastNumber, nextNumber);
    }

    return result;
}

Main();