/*
[Estrutura de Repetição , Arrays (também é possível criar apenas com Repetição)]
Crie um programa que calcule a sequência de Fibonacci, A sequência de fibonacci, é uma sequência iniciada por 0 e 1, e cada número subsequente é calculado pela soma dos dois anteriores, no caso 0 +1 = 1, o próximo e 1 +1 = 2, seguindo 1 +2 = 3,. e assim por diante. chegando a fórmula Fn = F(n- 1) + (n-2).

Os primeiros números da sequência são: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377…

Seu programa deve exibir os primeiros 20 números da sequência de Fibonacci.
*/

Console.WriteLine("Sequência Fibonacci. Para iniciar digite aperte ENTER");
Console.ReadLine();

int aux1 =0;
int aux2 = 1;
int fibo;

for (int i = 0; i < 20; i++)
{
    fibo = aux1 + aux2; // vai guardar o total da soma entre 0 + 1 = 1 (definido nas variáveis fora do FOR)
    Console.WriteLine(fibo); //vai mostrar no console a soma acima
    aux1 = aux2;//o valor 0 passa a receber 1
    aux2 = fibo;//o valor 1 passa a receber o próximo numero da soma cada vez que e vai fazer isso a cada interação enquanto o tamanho de for menor do que 20.
}