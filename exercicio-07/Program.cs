namespace exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool ehPrimo = true;

            if (numero <= 1)
            {
                ehPrimo = false;
            }
            else
            {
                for (int i = 2; i <= numero / 2; i++)
                {
                    if (numero % i == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }
            }

            if (ehPrimo)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }

            Console.ReadLine();
        }
    }
}
