namespace exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota da primeira prova: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da primeira prova: ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da segunda prova: ");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            double mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

            Console.WriteLine($"\nMédia ponderada: {mediaPonderada:F2}");
            Console.ReadLine();
        }
    }
}
