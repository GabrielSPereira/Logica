namespace Pergunta1
{
    internal class Program
    {
        static void Main()
        {
            CalculadoraDesconto.Pergunta1CalculoDescontoCarro();
        }
    }

    public static class CalculadoraDesconto
    {
        public static void Pergunta1CalculoDescontoCarro()
        {
            int totalCarrosAte2000 = 0;
            int totalGeral = 0;

            while (true)
            {
                int anoCarro;
                Console.WriteLine("Informe o ano do carro:");
                while (!int.TryParse(Console.ReadLine(), out anoCarro))
                {
                    Console.WriteLine("Ano inválido. Tente novamente.");
                }

                double precoCarro;
                Console.WriteLine("Informe o preço do carro:");
                while (!double.TryParse(Console.ReadLine(), out precoCarro) || precoCarro <= 0)
                {
                    Console.WriteLine("Preço inválido. Tente novamente.");
                    continue;
                }


                totalGeral++;
                if (anoCarro <= 2000)
                {
                    totalCarrosAte2000++;
                }

                double valorDesconto = CalculaValorDesconto(anoCarro, precoCarro);
                double valorAPagar = CalculaValorAPagar(precoCarro, valorDesconto);

                Console.WriteLine($"Valor do desconto: R${valorDesconto:F2}");
                Console.WriteLine($"Valor a ser pago: R${valorAPagar:F2}");

                Console.WriteLine("Deseja continuar calculando desconto? ('N' para encerrar)");
                if (Console.ReadLine()?.ToUpper() == "N")
                {
                    break;
                }
            }

            Console.WriteLine($"Total de carros até 2000: {totalCarrosAte2000}");
            Console.WriteLine($"Total geral: {totalGeral}");
        }

        public static double CalculaValorAPagar(double precoCarro, double valorDesconto)
        {
            return precoCarro - valorDesconto;
        }

        public static double CalculaValorDesconto(int anoCarro, double precoCarro)
        {
            double desconto = (anoCarro <= 2000) ? 0.12 : 0.07;
            return precoCarro * desconto;
        }
    }
}