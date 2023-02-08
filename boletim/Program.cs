Console.WriteLine("Digite a 1º nota: ");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a 2º nota: ");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a 3º nota: ");
int nota3 = int.Parse(Console.ReadLine());

int media = (nota1 + nota2 + nota3) /3;

if(media >= 6) {
    Console.WriteLine($"Aluno aprovado com média {media}");
} else if(media >= 5 && media < 6) {
    Console.WriteLine($"Aluno em Recuperação com média {media}");
} else {
    Console.WriteLine($"Aluno Reprovado com média{media}");
}