namespace Ex1Chap5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer une valeur");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer une valeur");
            int b = int.Parse(Console.ReadLine());
            int d = 0;
            int c = 0;
            while (c != b)
                d += a; c++;
            Console.WriteLine($"Le résultat de la multiplication est {d}");

        }
    }
}
