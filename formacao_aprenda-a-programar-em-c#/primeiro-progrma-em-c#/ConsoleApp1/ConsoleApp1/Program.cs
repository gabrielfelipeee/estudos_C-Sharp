using System.Runtime.CompilerServices;

string logo = @"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀";
string title = "Bem vindo ao Screen Sound";

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("U2", new List<int> { 8, 7, 9 });
bandas.Add("Calypso", new List<int>());


void ExibirLogoTitle()
{
    Console.WriteLine(logo);
    Console.WriteLine(title);
}

void Options()
{
    Console.Clear();
    ExibirLogoTitle();
    Console.WriteLine("Digite 1 um para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média da banda");
    Console.WriteLine("Digite 5 para sair \n");

    Console.Write("Digite sua opção: ");
    string option = Console.ReadLine()!;
    int optionToNumber = int.Parse(option);

    switch (optionToNumber)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            mediaNotaBanda();
            break;
        case 5:
            Console.WriteLine("Você saiu!");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}


void RegistrarBanda()
{
    Console.Clear();
    ExibirTitle("Registro de bandas");
    Console.Write("Digite os nomes das bandas que tu deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandas.Add(nomeBanda, new List<int>());

    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    Options();
}



void ExibirBandas()
{
    ExibirTitle("Exibindo todas as bandas registradas");
    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine(banda);
    }

    Console.ReadKey();
    Options();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTitle("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeBanda)) {
        Console.Write($"Dê uma nota para a banda {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeBanda].Add(nota);
        Console.Write("\nA nota foi registrada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
        Options();

    } else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu!");
        Console.ReadKey();
        Console.Clear();
        Options();
    }
    
}

void mediaNotaBanda()
{
    Console.Clear();
    ExibirTitle("Média da banda");
    Console.Write("Digite o nome da banda para ver a média: ");
    string nomeBanda = Console.ReadLine()!;
    if(bandas.ContainsKey(nomeBanda)) {
        double mediaBanda = bandas[nomeBanda].Average();
        Console.WriteLine($"A nota média da banda {nomeBanda} é: {mediaBanda}");
    }
}


void ExibirTitle(string title)
{
    int quantLetras = title.Length;
    string asteriscos = String.Empty.PadLeft(quantLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(title);
    Console.WriteLine(asteriscos + "\n");
}

Options();
