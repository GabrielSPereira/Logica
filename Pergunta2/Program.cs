namespace Pergunta2
{
    internal class Program
    {
        static void Main()
        {
            CalculadoraNota.Pergunta2CalculoNotaAluno();
        }        
    }

    public class CalculadoraNota
    {
        public static void Pergunta2CalculoNotaAluno()
        {
            while (true)
            {
                Console.WriteLine("Digite o número do aluno (ou 0 para encerrar):");
                int codigoAluno;
                while (!int.TryParse(Console.ReadLine(), out codigoAluno))
                {
                    Console.WriteLine("Código só aceita números. Digite novamente:");
                }

                if (codigoAluno == 0)
                {
                    break;
                }

                Console.WriteLine("Digite a primeira nota:");
                double nota1 = LerNota();
                Console.WriteLine("Digite a segunda nota:");
                double nota2 = LerNota();
                Console.WriteLine("Digite a terceira nota:");
                double nota3 = LerNota();

                double media = CalcularMediaPonderada(nota1, nota2, nota3);

                Console.WriteLine($"Aluno: {codigoAluno}");
                Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");
                Console.WriteLine($"Média: {media:F2} {(media >= 6 ? "APROVADO" : "REPROVADO")}");
            }
        }

        private static double LerNota()
        {
            double nota;
            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota inválida. Digite novamente:");
            }

            return nota;
        }

        public static double CalcularMediaPonderada(double nota1, double nota2, double nota3)
        {
            double maiorNota = Math.Max(nota1, Math.Max(nota2, nota3));
            double media = (maiorNota * 4 + (nota1 + nota2 + nota3 - maiorNota) * 3) / 10;
            return media;
        }
    }
}