// Ways to pass multiple arguments inside a method
class Program
{
    static void Main(string[] args)
    {
        // Instantianting a new vector 
        int resultVector = Vector.Sum(new int[] { 10, 20, 30, 40 });
        Console.WriteLine($"Sum: {resultVector}");


        // Using Params
        int resultUsingParams = Params.Sum(10, 10, 10, 10, 10, 50);
        Console.WriteLine($"Sum: {resultUsingParams}");
    }
}

// Using vector
class Vector
{
    public static int Sum(int[] values)
    {
        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return sum;
    }
}

// Using params 
class Params
{
    public static int Sum(params int[] values)
    {
        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return sum;
    }
}