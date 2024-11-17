
// Declarando um Array
int[] vetorInteiros = new int[10];

Console.WriteLine("Inserindo valores nos indices do Array com For!\n");

// Utilizando um For para percorrer o Array e atualizar seus indices
// Lenght retorna a quantidade de indices em um array
for (int i = 0; i < vetorInteiros.Length; i++)
{
    vetorInteiros[i] = i;
    Console.WriteLine($"Indice N°{i} valor {vetorInteiros[i]}\n");
}

Console.WriteLine("Exibindo os valores do Array com Foreach!\n");

// Percorrendo o Array com o Foreach, a variavel valor recebe o valor do indice do Array
foreach(int valor in vetorInteiros)
{
    Console.WriteLine($"Valor do indice = {valor}\n");
}

Console.WriteLine("Dobrando a quantidade de indices do Array e atribuindo valores!\n");

// Classe Array, utilizamos o metodo Resize para alterar a quantidade de indices do Array
Array.Resize(ref vetorInteiros, vetorInteiros.Length * 2);
for (int i = 0;i < vetorInteiros.Length; i++)
{
   vetorInteiros[i] = i;
   Console.WriteLine($"Indice N°{i} valor {vetorInteiros[i]}\n");
}

Console.WriteLine("Copiando os valores de um vetor para outro!\n");

// Copiando um vetor
int[] novoVetor = new int[20];
Array.Copy(vetorInteiros, novoVetor, vetorInteiros.Length);
for (int i = 0;i< novoVetor.Length; i++)
{
    Console.WriteLine($"Valores do novo vetor = {novoVetor[i]}\n");
}

Console.WriteLine("----------LISTAS EM C#----------\n");

// Declarando uma lista
List<string> listaEstados = new List<string>();

// Add tem como finalidade adicionar valores a uma lista
listaEstados.Add("SP");
listaEstados.Add("MG");
listaEstados.Add("ES");
listaEstados.Add("RJ");

// Count funciona como o Length, retorna a quantidade de indices de uma lista
for (int i = 0; i < listaEstados.Count; i++)
{
    Console.WriteLine($"Posição N° {i} valor {listaEstados[i]}\n");
}

// Remove um valor de uma lista
listaEstados.Remove("RJ");

// Capacity retorna a quantidade de indices da lista
Console.WriteLine($"Itens: {listaEstados.Count} Capacidade {listaEstados.Capacity}");