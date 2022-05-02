// Ways to pass multiple arguments inside a method

internal class Program
{
    private static void Main(string[] args)
    {
        // Instantianting a new vector 
        var resultVector = Vector.Sum(new[] { 10, 20, 30, 40 });
        Console.WriteLine($"Sum: {resultVector}");


        // Using Params
        var resultUsingParams = Params.Sum(10, 10, 10, 10, 10, 50);
        Console.WriteLine($"Sum: {resultUsingParams}");
    }
}

// Using vector
internal class Vector
{
    public static int Sum(int[] values)
    {
        var sum = 0;
        for (var i = 0; i < values.Length; i++) sum += values[i];

        return sum;
    }
}

// Using params 
internal class Params
{
    public static int Sum(params int[] values)
    {
        var sum = 0;
        for (var i = 0; i < values.Length; i++) sum += values[i];

        return sum;
    }
}