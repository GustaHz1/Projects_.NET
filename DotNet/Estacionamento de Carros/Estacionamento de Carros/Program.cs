using System.Globalization;
using System.Security.Cryptography.X509Certificates;

List<string> estacionamento = new List<string>();

int valorHora, tempo, valorEstacionamento, total;
int opcao = 0;
string veiculo;

Console.WriteLine("Qual o valor do estacionamento: \n");
valorEstacionamento = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor da hora no estacionamento: \n");
valorHora = int.Parse((Console.ReadLine()));

while (opcao != 4)
{
    Console.WriteLine("Qual ação deseja realizar:\n [1]Cadastrar o veículo\n [2]Remover o veiculo \n [3]Visualizar veiculos\n [4]Sair");
    opcao = int.Parse((Console.ReadLine()));

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite a placa do veículo: \n");
            veiculo = Console.ReadLine();
            estacionamento.Add(veiculo);
            Console.WriteLine($"Veiculo da placa {veiculo} cadastrado!\n");
            break;

        case 2:
            Console.WriteLine("Digite a placa do veículo que deseja remover: \n");
            veiculo = Console.ReadLine();

            if (estacionamento.Contains(veiculo))
            {
                estacionamento.Remove(veiculo);
                Console.WriteLine("Quantas horas o veiculo ficou no estacionamento: \n");
                tempo = int.Parse(Console.ReadLine());
                total = tempo * valorHora + valorEstacionamento;
                Console.WriteLine($"Total a ser pago R${total}\n");
                Console.WriteLine($"Carro da placa {veiculo} Removido\n");

                }
                else
                {
                    Console.WriteLine("Carro não se encontra no estacionamento \n");
                }
                break;

        case 3:
            for (int i = 0; i < estacionamento.Count; i++)
            {
                Console.WriteLine($"Placa {estacionamento[i]}\n");
            }
        break;

        case 4:
            break;

        default:
            Console.WriteLine("Valor invalido!");
            break;
    }
}