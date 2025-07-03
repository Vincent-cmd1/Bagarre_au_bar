namespace Bagarre_au_bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeRenaud renaud = new LeRenaud();

            int degat = renaud.Attaque();


            //Console.WriteLine($"{renaud.Nom} - {renaud.PointsDeVie}");
            Console.WriteLine("Hello");

            Console.ReadKey();
        }
    }
}
