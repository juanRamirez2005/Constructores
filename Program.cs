namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto();
            Console.WriteLine($"x = {punto1.X} y = {punto1.Y}");

            Punto punto2 = new Punto(5, 6);
            Console.WriteLine($"x = {punto2.X} y = {punto2.Y}");

            Punto punto3 = new Punto(8,9);
            Console.WriteLine($"x = {punto3.X} y = {punto3.Y}");
        }
    }
}