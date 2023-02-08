/*
[Estrutura de Repetição]
Crie um programa que receba um número inteiro, e a partir desse número exiba a tabuada do 0 até o 10 dele. Ex: Caso receba o número 2, a saída do programa deverá ser: 

2 X 0 = 0
2 X 1 = 2
2 X 2 = 4
2 X 3 = 6
*/

System.Console.WriteLine("Criando a estrutura da sua taboada");
System.Console.WriteLine("Digite abaixo de 0 a 10:");
int taboada = int.Parse(Console.ReadLine());

for(int multiplicador =  1; multiplicador <= 10; multiplicador++) {
    Console.WriteLine(multiplicador*taboada);
    }