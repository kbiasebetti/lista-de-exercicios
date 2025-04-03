namespace exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quilometragem inicial (km): ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem final (km): ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de combustível consumido (litros): ");
            double litrosConsumidos = Convert.ToDouble(Console.ReadLine());

            double distanciaPercorrida = kmFinal - kmInicial;
            double consumoPorKm = distanciaPercorrida / litrosConsumidos;

            Console.WriteLine($"\nDistância percorrida: {distanciaPercorrida} km");
            Console.WriteLine($"Consumo médio: {consumoPorKm:F2} km/l");
            Console.ReadLine();
        }
    }
}
