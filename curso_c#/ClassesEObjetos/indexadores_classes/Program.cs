using System;

/**
 Indexadores permitem que uma classe seja indexada como um array
**/


class Carro
{
    private int[] VelMax = new int[5] { 120, 240, 260, 300, 360};


    //Indexador
    public int this[int i]
    {
        get
        {
            return VelMax[i];
        }

        set
        {
            if (value > 0 && value <= 360)
            {
                VelMax[i] = value;
            }
            else
            {
                VelMax[i] = 360;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Carro c1 = new Carro();
        
        Console.WriteLine("Velocidade máxima: {0}", c1[4]);
    }
}