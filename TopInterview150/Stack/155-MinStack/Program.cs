namespace _155_MinStack;

internal abstract class Program
{
    static void Main(string[] args)
    {
        var obj = new MinStack();
        obj.Push(0);
        obj.Push(1);
        obj.Push(0);
        Console.WriteLine(obj.GetMin());
        obj.Pop();
        Console.WriteLine(obj.GetMin());
        obj.Pop();
        Console.WriteLine(obj.GetMin());
        obj.Pop();
        obj.Push(-2);
        obj.Push(-1);
        obj.Push(-2);
        Console.WriteLine(obj.GetMin());
        obj.Pop();
        Console.WriteLine(obj.Top());
        Console.WriteLine(obj.GetMin());
        obj.Pop();
        Console.WriteLine(obj.GetMin());
        obj.Pop();
    }
}

public class MinStack
{
    private readonly Stack<int> _nums = new();
    private readonly Stack<int> _minNums = new();

    public void Push(int val)
    {
        _nums.Push(val);

        if (_minNums.Count == 0 || val <= _minNums.Peek())
        {
            _minNums.Push(val);
        }

    }

    public void Pop()
    {
        _nums.TryPop(out int pop);

        if (_minNums.Peek() == pop)
        {
            _minNums.Pop();
        }
    }

    public int Top()
    {
        return _nums.Peek();
    }

    public int GetMin()
    {
        return _minNums.Peek();
    }
}
