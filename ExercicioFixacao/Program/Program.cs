using ExercicioFixacao.Vector;
class Program
{
    static void Main(string[] args)
    {

        int dataRent = int.Parse(Console.ReadLine());
        Vector[] room = new Vector[9];


        for (int i = 0; i < dataRent; i++)
        {
            string name = Console.ReadLine();
            string email = Console.ReadLine();
            int position = int.Parse(Console.ReadLine());

            room[position] = new Vector { Name = name, Email = email, Room = position };
        }

        Console.WriteLine("Busy Rooms:");
        foreach (var i in room)
        {
            if (i != null)
            {
                Console.WriteLine($"{i.Room}: {i.Name}, {i.Email}");
            }
        }
    }
}