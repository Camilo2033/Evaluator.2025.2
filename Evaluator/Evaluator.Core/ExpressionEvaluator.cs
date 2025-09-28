using System.Globalization;

namespace Evaluator.Core
{
    public class ExpressionEvaluator
    {
        public static double Evaluate(string infix)
        {
            var tokens = Tokenize(infix);
            var postfix = InfixToPostfix(tokens);
            return Calulate(postfix);
        }

        // Convierte la cadena en tokens (números y operadores)
        private static List<string> Tokenize(string expression)
        {
            var tokens = new List<string>();
            var number = string.Empty;

            foreach (char c in expression)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    number += c; // acumulamos dígitos o punto decimal
                }
                else if (IsOperator(c))
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        tokens.Add(number);
                        number = string.Empty;
                    }
                    tokens.Add(c.ToString());
                }
                else if (!char.IsWhiteSpace(c))
                {
                    throw new Exception($"Carácter no válido: {c}");
                }
            }

            if (!string.IsNullOrEmpty(number))
                tokens.Add(number);

            return tokens;
        }

        // Convierte de infijo a postfijo usando tokens
        private static List<string> InfixToPostfix(List<string> infixTokens)
        {
            var stack = new Stack<string>();
            var postfix = new List<string>();

            foreach (var token in infixTokens)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                {
                    postfix.Add(token);
                }
                else if (IsOperator(token[0]))
                {
                    if (token == ")")
                    {
                        while (stack.Peek() != "(")
                            postfix.Add(stack.Pop());
                        stack.Pop(); // eliminar '('
                    }
                    else
                    {
                        if (stack.Count > 0)
                        {
                            if (PriorityInfix(token[0]) > PriorityStack(stack.Peek()[0]))
                            {
                                stack.Push(token);
                            }
                            else
                            {
                                postfix.Add(stack.Pop());
                                stack.Push(token);
                            }
                        }
                        else
                        {
                            stack.Push(token);
                        }
                    }
                }
            }

            while (stack.Count > 0)
                postfix.Add(stack.Pop());

            return postfix;
        }

        private static bool IsOperator(char item) => item is '^' or '/' or '*' or '%' or '+' or '-' or '(' or ')';

        private static int PriorityInfix(char op) => op switch
        {
            '^' => 4,
            '*' or '/' or '%' => 2,
            '-' or '+' => 1,
            '(' => 5,
            _ => throw new Exception("Operador inválido."),
        };

        private static int PriorityStack(char op) => op switch
        {
            '^' => 3,
            '*' or '/' or '%' => 2,
            '-' or '+' => 1,
            '(' => 0,
            _ => throw new Exception("Operador inválido."),
        };

        // Evalúa la expresión en postfijo
        private static double Calulate(List<string> postfixTokens)
        {
            var stack = new Stack<double>();

            foreach (var token in postfixTokens)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    stack.Push(number);
                }
                else
                {
                    var op2 = stack.Pop();
                    var op1 = stack.Pop();
                    stack.Push(Calulate(op1, token[0], op2));
                }
            }

            return stack.Peek();
        }

        private static double Calulate(double op1, char item, double op2) => item switch
        {
            '*' => op1 * op2,
            '/' => op1 / op2,
            '^' => Math.Pow(op1, op2),
            '+' => op1 + op2,
            '-' => op1 - op2,
            _ => throw new Exception("Operador inválido."),
        };
    }
}