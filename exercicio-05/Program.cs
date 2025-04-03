namespace exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário base do funcionário: ");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o percentual de comissão (%): ");
            decimal percentualComissao = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o total das vendas realizadas (R$): ");
            decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

            decimal salarioFinal = salarioBase + (totalVendas * (percentualComissao / 100));

            Console.WriteLine($"\nSalário final: R$ {salarioFinal:F2}");
            Console.ReadLine();
        }
    }
}
