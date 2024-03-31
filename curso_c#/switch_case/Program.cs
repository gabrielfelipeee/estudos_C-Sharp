using System;
using System.Diagnostics;

class Switch {
    static void Main()
    {
        int tempo;
        char escolhaTransporte;
        string transporte = "";

        inicio: // label
        Console.Clear();

        Console.WriteLine("Belo Horizonte para Vitória");
        Console.WriteLine("Escolha o transporte: [A] Avião | [B] Ônibus | [C] Carro");
        escolhaTransporte = char.Parse(Console.ReadLine());


        switch (escolhaTransporte)
        {
            case 'A':
                tempo = 60;
                transporte = "Avião";
                break;
            case 'B':
                tempo = 300;
                transporte = "Ônibus";
                break;
            case 'C':
                tempo = 180;
                transporte = "Carro";
                break;
            default:
                tempo = -1;
                break;
        }

        if (tempo < 0)
        {
            Console.WriteLine("Transporte indisponível");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Transporte escolhido: {0}", transporte);
            Console.WriteLine("Tempo de viagem: {0} hora(s)", tempo / 60);
        }


        // Usando o goto para calcular o tempo de um novo transporte
        Console.Write("Calcular novamente? [s/n]");
        escolhaTransporte = char.Parse(Console.ReadLine());
        if(escolhaTransporte == 's')
        {
            goto inicio;
        }  else
        {
            Console.Clear();
            Console.WriteLine("Fim do programa");       
        }
    }
}