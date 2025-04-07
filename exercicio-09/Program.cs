namespace exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int valorTemporario = a;
                a = b;
                b = valorTemporario;
            }

            if (a > c)
            {
                int valorTemporario = a;
                a = c;
                c = valorTemporario;
            }

            if (b > c)
            {
                int valorTemporario = b;
                b = c;
                c = valorTemporario;
            }

            Console.WriteLine($"\nOrdem decrescente: {c}, {b}, {a}");
            Console.ReadLine();
        }
    }
}
