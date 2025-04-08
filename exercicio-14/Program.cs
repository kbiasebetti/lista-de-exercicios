namespace exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número limite para a sequência de Fibonacci: ");
            int limite = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;

            Console.WriteLine("Sequência de Fibonacci até " + limite + ":");

            while (a <= limite)
            {
                Console.Write(a + " ");
                int proximo = a + b;
                a = b;
                b = proximo;
            }

            Console.ReadLine();
        }
    }
}
