using ExercicioFixacao.Vector;

internal class Program
{
    private static void Main(string[] args)
    {
        var dataRent = int.Parse(Console.ReadLine());
        var room = new Vector[9];


        for (var i = 0; i < dataRent; i++)
        {
            var name = Console.ReadLine();
            var email = Console.ReadLine();
            var position = int.Parse(Console.ReadLine());

            room[position] = new Vector { Name = name, Email = email, Room = position };
        }

        Console.WriteLine("Busy Rooms:");
        foreach (var i in room)
            if (i != null)
                Console.WriteLine($"{i.Room}: {i.Name}, {i.Email}");
    }
}