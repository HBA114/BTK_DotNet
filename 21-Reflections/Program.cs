// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Math math = new Math(2,5);

// Console.WriteLine($"{math.Add(3,8)}");
// Console.WriteLine($"{math.Add2()}");

// Console.WriteLine($"{math.Multiply(3,8)}");
// Console.WriteLine($"{math.Multiply2()}");

var type = typeof(MathOperators);

MathOperators mathOperators = (MathOperators)Activator.CreateInstance(type, 6,7)!;

Console.WriteLine($"{mathOperators.Add(4,5)}");
Console.WriteLine($"{mathOperators.Add2()}");

public class MathOperators
{
    private int _number1;
    private int _number2;

    public MathOperators(int number1, int number2)
    {
        _number1 = number1;
        _number2 = number2;
    }

    public MathOperators()
    {

    }
    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public int Add2()
    {
        return _number1 + _number2;
    }

    public int Multiply2()
    {
        return _number1 * _number2;
    }
}