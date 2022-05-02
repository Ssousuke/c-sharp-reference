namespace ValoresNullable;

internal class Program
{
    public static void Main(string[] args)
    {
        // pattern value is zero
        double? X = null;
        double? Y = 10.0;

        // Print in default value or default
        Console.WriteLine(X.GetValueOrDefault());
        Console.WriteLine(Y.GetValueOrDefault());

        // check if there is value inside the variable
        // return True or False
        Console.WriteLine(X.HasValue);
        Console.WriteLine(Y.HasValue);

        // Getting value in variable
        if (X.HasValue)
            Console.WriteLine(X.Value);
        else
            Console.WriteLine("Variable X is null");

        if (Y.HasValue)
            Console.WriteLine(Y.Value);
        else
            Console.WriteLine("Variable Y is null");
    }
}