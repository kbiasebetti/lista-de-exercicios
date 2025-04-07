namespace exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números ímpares entre 100 e 200:");

            for (int i = 101; i < 200; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
