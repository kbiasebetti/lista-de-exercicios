namespace exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em graus Celsius: ");
            decimal grausCelsius = Convert.ToDecimal(Console.ReadLine());

            decimal grausFare = (grausCelsius * 9 / 5) + 32;

            Console.WriteLine($"\nA temperatura em Fahrenheit é: {grausFare:F2}°F");
            Console.ReadLine();
        }
    }
}
