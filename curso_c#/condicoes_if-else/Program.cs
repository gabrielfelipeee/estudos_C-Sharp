using System;

class Condicoes
{
    static void Main()
    {
        float nota = 40f;
        string result;


        if (nota < 50)
        {
            result = "Reprovado";
        } else if (nota < 60)
        {
            result = "Recuperação";
        } else
        {
            result = "Aprovado";
        }



        // condição aninhada => Uma estrutura dentro da outra
        var num = 99;

        if (num > 0)
        {
            Console.WriteLine("É um número positivo");
            if (num % 2 == 0)
            {
                Console.WriteLine("Também é um número par");
            }
            else
            {
                Console.WriteLine("Também é um número impar");
            }
        }
        else
        {
            Console.WriteLine("É um número negativo");
        }
    }
}