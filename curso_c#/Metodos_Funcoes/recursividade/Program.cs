using System;

/*
Recursividade refere-se à capacidade de uma função chamar a si mesma diretamente ou indiretamente para resolver um problema.
*/

class Recursividade
{
    public int Fatorial(int num)
    {
        int res;
        if (num <= 1)
        {
            res = 1;
        }
        else
        {
            res = num * Fatorial(num - 1); // Recursividade
        }
        return res;
    }
}

class Program
{
    static void Main()
    {
        Recursividade c1 = new Recursividade();
        Console.WriteLine(c1.Fatorial(6));
    }
}

