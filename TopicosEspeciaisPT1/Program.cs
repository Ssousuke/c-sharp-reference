using System;
namespace TopicosEspeciaisPT1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inferência de Tipos: Palavra var
            // Os tipos são inferidos em tempo de compilação e pelo proprio compilador
            // int
            var x = 10;
            // double 
            var y = 20.0;
            // string 
            var z = "Olá Mundo!";
            Console.WriteLine($"Tipo: {x.GetType()}");
            Console.WriteLine($"Tipo: {y.GetType()}");
            Console.WriteLine($"Tipo: {z.GetType()}");

            // Data e Hora atual
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

        }
    }
}