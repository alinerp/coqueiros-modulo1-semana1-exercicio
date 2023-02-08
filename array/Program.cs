System.Console.WriteLine("Digite o a quantidade de pessoas da lista: ");
int tamanho = int.Parse(Console.ReadLine());

string[] nomes = new string[tamanho];

for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine($"Digita o {i+1} nome: ");
}