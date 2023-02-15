/*
[Estrutura de Decisão]
Faça um programa que peça os 3 lados de um triângulo. O programa deverá informar se os valores podem ser um triângulo, primeiro passo será verificar se os lados formam um triângulo. para isso valide: 
 Se a soma de quaisquer dos dois lados é maior que o terceiro:
Lado1 + Lado2 > Lado3 ou;
Lado3 + Lado2 > Lado1 ou;
Lado3 + Lado1 > Lado2 ou;
Caso nenhuma das opções seja verdadeira, seu programa deverá informar que as medidas não formam um triângulo e encerrar.

Caso formem um triângulo, informe  qual o tipo dele: equilátero, isósceles ou escaleno. Dicas:
Triângulo Equilátero: três lados iguais;
Lado1 = Lado2 = lado3
Triângulo Isósceles: quaisquer dois lados iguais;
Lado1 = Lado2 ou;
Lado2 = Lado3 ou;
Lado3 = Lado1 ou;
Triângulo Escaleno: três lados diferentes;
Lado1 != Lado2 E;
Lado2 != Lado3 E;
Lado3 != Lado1 E;
*/

Console.WriteLine("Descubra qual o tipo de triangulo você pode fazer. Para isso informe abaixo, a medida de cada lado do triângulo.");
Console.WriteLine("Lado nº 01: ");
int lado1 = int.Parse(Console.ReadLine());
Console.WriteLine("Lado nº 02: ");
int lado2 = int.Parse(Console.ReadLine());
Console.WriteLine("Lado nº 03: ");
int lado3 = int.Parse(Console.ReadLine());

if(lado1 == lado2 && lado2 == lado3 && lado3 == lado1) {
    System.Console.WriteLine("Seu triângulo é: Equilátero");
} else if(lado1 == lado2 && lado2 == lado3 && lado3 == lado1) {
    System.Console.WriteLine("Seu triâgulo é: Isósceles");
} else if(lado1 != lado2 && lado2 != lado3 && lado3 != lado1){
    System.Console.WriteLine("Seu triângulo é: Escaleno");
} else {
    Console.WriteLine("Ops! As medidas que você passou não formam um triângulo. Tente novamente.");
};