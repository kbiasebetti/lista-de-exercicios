namespace exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para calcular o fatorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            long fatorial = 1;
            string sequencia = "";

            for (int i = numero; i >= 1; i--)
            {
                fatorial *= i;

                if (i == 1)
                    sequencia += "1";
                else
                    sequencia += i + " x ";
            }

            Console.WriteLine($"\n{numero}! = {sequencia} = {fatorial}");
            Console.ReadLine();
        }
    }
}
