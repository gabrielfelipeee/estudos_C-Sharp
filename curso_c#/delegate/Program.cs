using System;

/*
Um delegate é um elemento que permite que você faça referência a um método
*/

delegate int Operacao(params int[] nums);
class Math
{
    public static int Soma(params int[] nums)
    {
        int res = 0;
        foreach (int num in nums)
        {
            res += num;
        }
        return res;
    }
    public static int Multiplicacao(params int[] nums)
    {
        int res = 1;
        foreach (int num in nums)
        {
            res *= num;
        }
        return res;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int soma, multi;

        Operacao d1 = new Operacao(Math.Soma);
        Operacao d2 = new Operacao(Math.Multiplicacao);

        soma = d1(10, 20);
        Console.WriteLine(soma);

        Console.WriteLine("-----------------------------------------");

        multi = d2(10, 2);
        Console.WriteLine(multi);
    }
}