using Pergunta1;
using Pergunta2;

namespace TestesPerguntas
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1000, 100, ExpectedResult = 900)]
        [TestCase(2000, 200, ExpectedResult = 1800)]
        [TestCase(3000, 300, ExpectedResult = 2700)]
        public double CalculaValorAPagar_CalculaCorretamente(double precoCarro, double valorDesconto)
        {
            return CalculadoraDesconto.CalculaValorAPagar(precoCarro, valorDesconto);
        }

        [TestCase(2000, 1000, ExpectedResult = 120)]
        [TestCase(2001, 1000, ExpectedResult = 70)]
        public double CalculaValorDesconto_CalculaCorretamente(int anoCarro, double precoCarro)
        {
            return CalculadoraDesconto.CalculaValorDesconto(anoCarro, precoCarro);
        }

        [TestCase(5, 5, 5, ExpectedResult = 5)]
        [TestCase(6, 7, 8, ExpectedResult = 7.1)]
        [TestCase(7, 7, 9, ExpectedResult = 7.8)]
        [TestCase(9, 8, 7, ExpectedResult = 8.1)]
        [TestCase(4, 7, 10, ExpectedResult = 7.3)]
        public double CalcularMediaPonderada_Test(double nota1, double nota2, double nota3)
        {
            return CalculadoraNota.CalcularMediaPonderada(nota1, nota2, nota3);
        }

        [TestCase("2023-05-06", "2023-05-08", ExpectedResult = 0.00)]
        [TestCase("2023-05-07", "2023-05-09", ExpectedResult = 2 + 2 * 0.03)]
        [TestCase("2023-05-01", "2023-05-02", ExpectedResult = 0.00)]
        [TestCase("2023-04-21", "2023-04-24", ExpectedResult = 0.00)]
        [TestCase("2023-04-07", "2023-04-11", ExpectedResult = 2 + 4 * 0.03)]
        [TestCase("2023-05-10", "2023-05-10", ExpectedResult = 0.00)]
        [TestCase("2023-05-11", "2023-05-10", ExpectedResult = 0.00)]
        [TestCase("2023-05-08", "2023-05-09", ExpectedResult = 2 + 1 * 0.03)]

        public async Task<double> CalculoValorTotalJuros_CalculaCorretamente(string dataVencimentoOriginalStr, string dataVencimentoNovaStr)
        {
            // Arrange
            var dataVencimentoOriginal = DateTime.Parse(dataVencimentoOriginalStr);
            var dataVencimentoNova = DateTime.Parse(dataVencimentoNovaStr);

            // Act
            var result = await CalculadoraValorMultaJurosBoleto.CalculoValorTotalJuros(dataVencimentoOriginal, dataVencimentoNova);

            // Assert
            return result;
        }
    }
}