namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Halo", "Final Fantasy", "Gears of War", "Kingdom Hearts" };

            var gameNameLength = list.OrderBy(x => x.Length);

            foreach (string game in gameNameLength)
            {
                Console.WriteLine(game);
            }
        }
    }
}
