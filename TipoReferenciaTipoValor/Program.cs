namespace TipoReferenciaTipoValor
{
    class Program
    {
        public static void Main(string[] args)
        {
            Point p;

            p.X = 20;
            p.Y = 10;

            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);
        }
    }
}