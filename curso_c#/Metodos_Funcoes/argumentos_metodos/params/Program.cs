using System;

class Params
{
    static void Main()
    {
        Soma();
        Soma(10);
        Soma(10, 20);
    }



    // Com o params, não precisa especificar quanrtos argumentos o método irá ter
    static void Soma(params int[] num)
    {
        int res = 0;
        if (num.Length == 0)
        {
            Console.WriteLine("Não existe valores para somar");
        } else if (num.Length == 1)
        {
            Console.WriteLine("Valores insuficientes para somar");
        }
        else
        {
            foreach (int n in num)
            {
                res += n;
            }
            Console.WriteLine("O resusltado da soma é: {0}", res);
        }
    }
}