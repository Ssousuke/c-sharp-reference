using System.Globalization;

// a vector in programming is the name given to a one-dimensional array

// array is data structures 
// homogeneous
// ordering
// allocated only once to a continuous block of memory

// advantages
// immediate access to elements in positions

// disadvantage 
//  size fix
// difficulty inserting elements   

namespace VetoresPt2.Vector02
{
    class Vector02
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vector = new double [n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            foreach (var i in vector)
            {
                sum += i;
            }

            Console.WriteLine($" Sum: {sum}");
            Console.WriteLine($" Average: {sum / n}");
        }
    }
}