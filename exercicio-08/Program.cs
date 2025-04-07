namespace exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A + B < C)
            {
                Console.WriteLine("A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("A + B não é menor que C.");
            }
            Console.ReadLine();
        }
    }
}
