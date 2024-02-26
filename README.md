Solução possui 4 projetos sendo três projetos para cada pergunta em .NET 6 e um para testes unitários utilizando em NUnit.

Pergunta 1
```
Uma concessionária de carros está vendendo os seus veículos com desconto.

Faça um algoritmo em Portugol (ou na linguagem de sua preferência) que calcule e exiba o valor do desconto e o valor a ser pago pelo cliente de vários carros.

O desconto deverá ser calculado de acordo com o ano do veículo.

• Até 2000 - 12%
• Acima de 2000 - 7%


O algoritmo deverá perguntar se deseja continuar calculando desconto até que a resposta seja “N” (Não).

Informar total de carros com ano até 2000 e total geral.
```
Pergunta 2
```
Escreva um algoritmo em Portugol (ou na linguagem de sua preferência), que leia um número não determinado de valores.

Cada conjunto formado por número do aluno (código) e suas três notas.

Calcular para cada aluno a média ponderada com pesos respectivos de 4 para a MAIOR nota, e 3 para as outras duas notas.

Escrever o número do aluno (código), suas 3 notas, a média calculada e uma mensagem (APROVADO), se a média for ≥ 6 e (REPROVADO) se a média for < 6.

Encerrar a leitura de valores assim que for digitado 0 no código de aluno.
```

Pergunta 4 (na pasta Logico)
```
Escreva um algoritmo em Portugol (ou na linguagem de sua preferência), para realizar o recálculo de Boletos.
Ele deverá ler a data de vencimento original, a data de vencimento nova (data de pagamento) e valor do boleto, e deverá apresentar o valor do boleto recalculado, e o valor total dos juros do período.

Você deve considerar:

• Valor dos juros por dia: R$ 0,03 e Valor da multa: R$ 2,00 (valores fixos)
• As datas podem ser informadas com o tipo de dados data
• As datas podem ser comparadas com os Operadores Relacionais, e podem ser usados Operadores Aritméticos
• Ex.: data <- data + 1 // Acrescenta um dia na data
• Ex.: numDias <- dataFim - dataInicio // Retorna o número de dias entre as duas datas
• Existe uma função VerificaFeriado(data : data) : lógico
• Essa função retorna VERDADEIRO quando uma data for feriado, e FALSO caso contrário
• Existe uma função VerificaFinalDeSemana(data : data) : lógico
• Essa função retorna VERDADEIRO quando uma data for final de semana, e FALTO caso contrário

As regras de recálculo que devem ser respeitadas:

1. Se a data de vencimento for final de semana ou feriado, e a data de pagamento no dia útil consecutivo, não deve ser cobrado juros nem multa. Ex.: Vencimento sábado e pagamento na segunda-feira;
2. Se a data de vencimento for final de semana ou feriado, e o pagamento for posterior ao dia útil consecutivo, deve ser cobrado juros de todo o período. Ex.: Vencimento sábado e pagamento na terça-feira: três dias de juros + multa.
3. Se a data de vencimento for feriado, e o pagamento no dia seguinte (dia útil), não deve ser cobrado juros nem multa. Ex.: Vencimento 01/maio/2023 e pagamento 02/maio/2023;
4. Se a data de vencimento for feriado antecessor a um final de semana, e o pagamento for na segunda-feira (dia útil consecutivo), não deve ser cobrado juros nem multa. Ex.: Vencimento 21/abril/2023 e pagamento 24/abril/2023;
5. Se a data de vencimento for feriado, e o pagamento dois dias úteis consecutivos após feriado, deve ser cobrado jutos de todo o período. Ex. Vencimento 07/abril/2023 e pagamento 11/abril/2023: quatro dias de juros + multa;
6. Se o vencimento for dia útil, e o pagamento no mesmo dia, não deve ser cobrado juros nem multa;
7. Se a data de pagamento for anterior à data de vencimento, não deve ser cobrado juros nem multa;
8. Se o vencimento for dia útil, e o pagamento no dia útil consecutivo, dever ser cobrado juros e multa de apenas um período. Ex.: Vencimento 08/maio/2023 pagamento 09/maio/2023: um dia de juros + multa.
```
