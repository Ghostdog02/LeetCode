internal class Program
{
    private static readonly Dictionary<string, Func<int, int, int>> Operations = new()
    {
        { "+", (a, b) => a + b },
        { "-", (a, b) => a - b },
        { "*", (a, b) => a * b },
        { "/", (a, b) => a / b }
    };
    
    public static void Main(string[] args)
    {
        EvalRPN(["4","13","5","/","+"]);
    }
    
    static int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        var validOperators = new HashSet<string>() {"+", "-", "*", "/"};
                
        foreach (string token in tokens)
        {
            if (Operations.TryGetValue(token, out var func))
            {
                int num1 = stack.Pop();
                int num2 = stack.Pop();
                
                stack.Push(func(num2, num1));
            }

            else
            {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}