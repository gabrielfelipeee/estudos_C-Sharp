using System;

class FormatacaoSaida
{
    static void Main()
    {
        int n1, n2, n3;
        n1 = 10; 
        n2 = 20; 
        n3 = 30;

        // Por índices:       0       1       2   => 0   1   2 
        Console.WriteLine("n1={0}, n2={1}, n3={2}", n1, n2, n3); // output: n1=10, n2=20, n3=30


        double porcentagem = 0.1; 
        Console.WriteLine("Porcentegem: {0:p}", porcentagem);

        double moedaReal = 100;
        Console.WriteLine("Real: {0:c}", moedaReal);



        

        int v1, v2, soma;
        Console.Write("Digite um número: ");
        v1 = int.Parse(Console.ReadLine());

        Console.Write("Digite um outro número: ");
        v2 = int.Parse(Console.ReadLine());

        soma = v1 + v2;
        Console.Clear();
        Console.Write("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);
    }
}