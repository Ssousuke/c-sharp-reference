// Modificadores de acesso Ref e Out
namespace ModificaroesRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Calculator.Triple(ref x);
            Console.WriteLine($"Triple: {x}");


            int z = 10;
            int quadruple;
            Calculator.Quadruple(z, out quadruple);
            Console.WriteLine($"Quadruple: {quadruple}");
        }
    }

    class Calculator
    {
        // Ref
        // A variável passada como parametro Ref deve ser iniciada
        public static void Triple(ref int value)
        {
            value *= 3;
        }

        // Out
        // A variável passada como parametro Out não precisa ter sido iniciada
        public static void Quadruple(int origin, out int result)
        {
            result = origin * 4;
        }
    }
}


