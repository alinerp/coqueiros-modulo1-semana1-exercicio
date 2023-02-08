/*[Estrutura de Decisão]
 Crie um programa para o cálculo de imposto sobre uma folha de pagamento, o programa deve receber o valor do salário bruto, e de acordo com os critérios abaixo, calcular o valor do imposto a pagar:
 
 Salário Bruto até R$900,00 (inclusive) – Isento; - neste caso o programa retorna 0;
Salário Bruto de R$ 1500, 00 (inclusive) – desconto de 5%;
Salário bruto até R$ 2500,00 (Inclusive) – desconto de 10%;
Salário bruto acima de 2500 – Desconto de 20%.

Ex: 
Se o salário bruto for de 1800,00 - o desconto será de 10%, de acordo com a tabela, portanto  o valor de imposto devido será de R$180,00.
Se o salário bruto for de 2500,00 - o desconto será de 10%, de acordo com a tabela, portanto  o valor de imposto devido será de R$250,00.

Exiba o valor que será cobrado de imposto sobre o salário.*/

Console.WriteLine("Digite o seu salario bruto para saber qual o valor do imposto a ser retido:");
double salario = double.Parse(Console.ReadLine());
Console.WriteLine(salario);

if(salario <= 900){
    Console.WriteLine($"O valor do imposto a ser retido é de: R$0,00");
} else if(salario > 900 && salario <= 1500){
    double desconto = salario * 0.05;
    System.Console.WriteLine($"O valor do imposto a ser retido é de: {desconto}");
} else if(salario > 1500 && salario <= 2500) {
    double desconto = salario * 0.1;
    System.Console.WriteLine(desconto);
} else {
    double desconto = salario * 0.2;
    System.Console.WriteLine(desconto);
};
