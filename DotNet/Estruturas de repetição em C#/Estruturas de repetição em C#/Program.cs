
// Sintaxe FOR em C#
using System.ComponentModel.Design;

int numero;

Console.Write("Digite o numero que quer realizar a tabuada: ");
numero = int.Parse(Console.ReadLine());

// Declaramos a variavel controladora e em seguida fazemos uma condição com ela
for(int i = 0; i <= 10; i++)
{
    int valor = i * numero;
    Console.WriteLine($"{i} X {numero} = {valor}\n");
}

Console.WriteLine("Realizando a tabuada com o While\n");
// Sintaxe While em C#
int condicao = 1;

// No While declaramos sua condição e será executada enquanto for verdadeiro
while(condicao <= 10)
{
    Console.WriteLine($"{numero} X {condicao} = {numero * condicao}\n");
    condicao++;
}

Console.WriteLine("Realizando a tabuada com Do/While\n");
// Sintaxe de Do/While em C#
int condicao_do = 1;

// O bloco de código executa uma primeira vez, depois executa a condição para continuar
do
{
    Console.WriteLine($"{condicao_do} X {numero} = {condicao_do * numero}\n");
    condicao_do++;
}while(condicao_do <= 10);


Console.WriteLine("----------Criando um Menu---------- \n");

string opcao;
bool variavel = true;

while (variavel)
{
    Console.WriteLine("|[1] Novo Usuario\n");
    Console.WriteLine("|[2] Logar\n");
    Console.WriteLine("|[3] Apagar Usuario\n");
    Console.WriteLine("|[4] Sair\n");
    Console.Write("Digite a opção que deseja: \n");
    opcao = Console.ReadLine();

    // Sintaxe de Switch/Case, disponibiliza opções para o usuario
    // Caso nenhuma condição seja atendida temos o Default, que executa quando nenhuma das condições acima for verdadeira
    switch (opcao)
    {
        case "1":
            Console.WriteLine("Criando novo usuario!\n");
            break;
        case "2":
            Console.WriteLine("Logando!\n");
            break;
        case "3":
            Console.WriteLine("Excluindo Usuario\n");
            break;
        case "4":
            variavel = false;
            break;
        default:
            Console.WriteLine("Valor invalido\n");
            break;
    }
}