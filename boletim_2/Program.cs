/*
[Estrutura de Repetição , Arrays]
Utilizando como base o programa do boletim (Exercício 3), crie uma nova versão dele, mas desta vez obtenha o nome do aluno, a quantidade de notas que serão utilizadas para compor a média, e cada uma das notas. 

Após as entradas o programa deve calcular as médias, somando todas as notas e dividindo pelo número de notas, validar se o aluno foi aprovado, ficou de recuperação ou reprovado, utilizando os mesmos critérios: 
Se nota maior ou igual 6 Aprovado 
Se nota maior ou igual 5, e menor que 6 : Recuperação 
Se nota menor que 5 : Exibir -> Reprovado 

E por fim o programa deve exibir o boletim do aluno, no formato: 
Aluno: {Nome aluno}  
N1: {nota1} 
N2: {nota2} 
N3 {Nota3}
Nn: {Notan}
Média: {Valor da media} - {Aprovado Recuperação ou Reprovado}

Ex: 
Saída: Qual o nome do aluno? 
Entrada :  Vitor
Saída: quantas notas serão usadas para compor a média? 
Entrada: 2 
Saída: Digite a 1a nota: 
Entrada: 8
Saída: Digite a 2a nota:
Entrada: 4
Saída : Aluno: Vitor
N1: 8
N2: 1
Média: 6 - Aprovado 
*/

//Inicio do programa, coleta de dados
Console.Clear();
Console.WriteLine("Qual o nome do aluno?");
string nomeAluno = Console.ReadLine();
Console.WriteLine("Quantas notas serão usadas para compor a média?");
int quantidadeNotas = int.Parse(Console.ReadLine());

//Preparação do FOR
int[] listaNotas = new int[quantidadeNotas];// Quantidade de notas que será salva em cada indice(posição) do array
int somaNotas =0;//Iniciar sempre com 0 para ele ter um parâmetro de onde iniciar a contagem

//
for(int i = 0; i < quantidadeNotas; i++){
    Console.WriteLine($"Digite a nota {i+1}: "); // i+1 é apenas uma gambi para iniciar a contagem em 1
    int valorNota = int.Parse(Console.ReadLine());
    listaNotas[i] = valorNota; //listaNota na posição i recebe o dado salvo na variável valorNota
    somaNotas = somaNotas + valorNota;// somaNotas = o dado salvo em somaNotas acrescentado do valorNota, ou seja, total de todas as notas digitas no final do FOR.
}

int media = somaNotas / quantidadeNotas; 

//Resultado do programa
Console.WriteLine($"Aluno: {nomeAluno}");
for (int i = 0; i < quantidadeNotas; i++)
{
    Console.WriteLine($"Nota: {listaNotas[i]}"); //Vai mostrar todas as notas que estão salvas dentro do array listaNotas e exibir.
}

if(media >= 6) {
    Console.WriteLine($"Aluno aprovado com média {media}");
} else if(media >= 5 && media < 6) {
    Console.WriteLine($"Aluno em Recuperação com média {media}");
} else {
    Console.WriteLine($"Aluno Reprovado com média{media}");
    };






