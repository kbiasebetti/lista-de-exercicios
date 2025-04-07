namespace exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"\nSeu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Condição: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Condição: Acima do peso");
            }
            else
            {
                Console.WriteLine("Condição: Obeso");
            }

            Console.ReadLine();
        }
    }
}
