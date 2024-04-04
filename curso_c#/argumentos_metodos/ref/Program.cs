using System;

class Ref
{
    static void Main()
    {


        // Passagem por referência
        int num = 10;

        // Com o ref: o argumento irá substituir o espaço na memória da variável num;
        // Sem o ref: o argumento será criado em um novo espaço, e o num continuaria sendo 10;
        Dobrar(ref num);

        // Com ref irá imprimir: 20 | sem o ref: 10
        Console.WriteLine(num);



        // Passagem por valor (sem o ref)
        int number = 100;
        Desconto(number); // output: 90
        Console.WriteLine(number);  // output: 100
    }

    static void Dobrar(ref int num)
    {
       num *= 2;
    }

    static void Desconto(int number)
    {
        number = number - (number * 10 / 100);   
        Console.WriteLine(number);
    }
}