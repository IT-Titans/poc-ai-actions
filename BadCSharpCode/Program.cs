namespace BadCSharpCode;

class Program
{
    static void Main(string[] args)
    {
        var input = int.Parse(args[0]);
        Console.WriteLine("Square: " + Square(input));

        var greeting = CreateGreeting(input);
        Console.WriteLine("Greeting: " + greeting);
    }

    private static long Square(int input)
    {
        if (input == null) throw new Exception("input is null");
        return DoSquare(input);
    }
    
    private static long DoSquare(int input)
    {
        return input * input;
    }
    
    private static string CreateGreeting(int input)
    {
        var result = string.Empty;
        result += "Hello ";
        result += input > 0 ? "Madam" : "Mister";
        result += " ";
        result += 'X';
        result += "!!!";
        return result;
    }

}