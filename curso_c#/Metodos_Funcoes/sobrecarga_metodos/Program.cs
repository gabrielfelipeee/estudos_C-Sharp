using System;


/*
A sobrecarga de métodos é um conceito que permite a definição de múltiplas versões de um método dentro de uma classe, 
com o mesmo nome, mas com diferentes parâmetros. 
*/
class Calc
{
    public int Soma(params int[]nums)
    {
        int res = 0;
        foreach(int num in nums)
        {
            res += + num;
        }
        return res;
    }
    public double Soma(params double[]nums)
    {
        double res = 0;
        foreach (double num in nums)
        {
            res += +num;
        }
        return res;
    }
}

class Program
{
    static void Main()
    {
        Calc calc = new Calc();

        int resInt = calc.Soma(10, 20);
        double resDouble = calc.Soma(10.65, 20.58);

        Console.WriteLine(resInt);
        Console.WriteLine(resDouble);
    }
}

