using Nager.Holiday;

namespace Pergunta4
{
    internal class Program
    {
        static async Task Main()
        {
            await CalculadoraValorMultaJurosBoleto.CalculaValorMultaJurosBoleto();
        }
    }
}

public class CalculadoraValorMultaJurosBoleto
{
    const int valorPadraoMulta = 2;

    public static async Task CalculaValorMultaJurosBoleto()
    {
        DateTime dataVencimentoOriginal, dataVencimentoNova;
        double valorBoleto;

        Console.WriteLine("Informe a data de vencimento original (dd/mm/aaaa):");
        while (!DateTime.TryParse(Console.ReadLine(), out dataVencimentoOriginal))
        {
            Console.WriteLine("Data inválida. Tente novamente utilizando a formatação (dd/mm/aaaa).");
        }

        Console.WriteLine("Informe a data de vencimento nova (data de pagamento) (dd/mm/aaaa):");
        while (!DateTime.TryParse(Console.ReadLine(), out dataVencimentoNova))
        {
            Console.WriteLine("Data inválida. Tente novamente utilizando a formatação (dd/mm/aaaa).");
        }

        Console.WriteLine("Informe o valor do boleto:");
        while (!double.TryParse(Console.ReadLine(), out valorBoleto))
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
        }

        if (dataVencimentoNova < dataVencimentoOriginal)
        {
            Console.WriteLine("Erro: Data de pagamento anterior à data de vencimento.");
            return;
        }

        double valorTotalJuros = await CalculoValorTotalJuros(dataVencimentoOriginal, dataVencimentoNova);

        double valorRecalculado = valorBoleto + valorTotalJuros;

        // Exibir resultados
        Console.WriteLine($"Valor do boleto recalculado: R$ {valorRecalculado:F2}");
        Console.WriteLine($"Valor total dos juros do período: R$ {valorTotalJuros:F2}");
    }

    public static async Task<double> CalculoValorTotalJuros(DateTime dataVencimentoOriginal, DateTime dataVencimentoNova)
    {
        if (await ObterProximoDiaUtil(dataVencimentoOriginal) < dataVencimentoNova)
        {
            return valorPadraoMulta + (dataVencimentoNova - dataVencimentoOriginal).Days * 0.03;
        }

        return 0;
    }

    static async Task<bool> VerificaFeriadoOuFinalDeSemana(DateTime data)
    {
        try
        {
            if (VerificaFeriado(data))
            {
                return true;
            }

            using var holidayClient = new HolidayClient();
            var holidays = await holidayClient.GetHolidaysAsync(data.Year, "br");

            var isFeriado = holidays.Any(o => o.Date == data);
            return isFeriado;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.ToString());
        }
    }

    private static bool VerificaFeriado(DateTime data) => data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;

    private static async Task<DateTime> ObterProximoDiaUtil(DateTime data)
    {
        while (await VerificaFeriadoOuFinalDeSemana(data))
        {
            data = data.AddDays(1);
        }

        return data;
    }
}
