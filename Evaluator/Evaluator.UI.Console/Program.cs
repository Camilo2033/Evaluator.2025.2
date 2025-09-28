using Evaluator.Core;
using System.Globalization;

Console.WriteLine("Hello, Evaluator");
var infix1 = "4*5/(4+6)";
var result1 = ExpressionEvaluator.Evaluate(infix1);
Console.WriteLine($"{infix1}={result1}");

var infix2 = "4*(5+6-(8/2^3)-7)-1";
var result2 = ExpressionEvaluator.Evaluate(infix2);
Console.WriteLine($"{infix2}={result2}");

var infix3 = "123^(1/2)";
var result3 = ExpressionEvaluator.Evaluate(infix3);
Console.WriteLine($"{infix3}={result3}");

Console.WriteLine("=== Evaluador de Expresiones ===\n");

while (true)
{
    Console.Write("> ");
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input) || input.ToLower() == "salir")
        break;

    try
    {
        var result = ExpressionEvaluator.Evaluate(input);
        Console.WriteLine($"{input} = {result.ToString(CultureInfo.InvariantCulture)}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}