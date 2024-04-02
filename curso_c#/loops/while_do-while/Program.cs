using System;


class WhileAndDoWhile
{
    static void Main()
    {
        // While => Enquanto
        int i = 1;
        while(i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }


        // Do while 
        string senha = "123";
        string senhauser;
        int tentativas = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Digite a senha");
            senhauser = Console.ReadLine();
            tentativas++;
        } while( senha != senhauser);
        Console.WriteLine("Senha correta, tentativas: {0}", tentativas);




        // Diferença:

        // While => Testa e depois executa
        // Ex:
        int num = 5;
        while(num < 5)
        {
            Console.WriteLine(num); // Não irá imprimir, pois a condição é false
        }

        // Do While => Executa e depois testa: Sempre será executado, pelo menos uma vez
        // Ex:
        do
        {
            Console.Write(num); // Imprimiu, pois executou primeiro e depois fez o teste
        } while(num < 5);
    }
}