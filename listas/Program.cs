List<string> lista = new List<string>(); // Tipo nome = atribuição (tipo lista de texto)

//var lista = new Listen<string>; Pode ser digitado assim tbm.

lista.Add("Texto");

Console.WriteLine("Digite um nome:");

lista.Add(Console.ReadLine());

Console.WriteLine(lista[0]);
