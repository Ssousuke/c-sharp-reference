// Instanciando uma Matriz
class Matriz
{
    static void Main(string[] args)
    {
        // Instanciando uma matriz de duas linhas e três colunas
        double[,] matriz = new double[2, 3];

        // Lenght é usando para mostrar o total de elementos na matriz
        Console.WriteLine(matriz.Length);

        // GetRank é usado para mostrar o número de demenssões da matriz
        Console.WriteLine(matriz.Rank);

        // GetLenght mostra a quantidade de dimenssões de um elemento especifico no Array
        Console.WriteLine(matriz.GetLength(0));
    }
}