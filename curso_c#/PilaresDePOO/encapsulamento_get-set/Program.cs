using System;

class Carro
{
    private int VelMax;
    public int VM 
    { 
        get {
            return VelMax;
        }

        set
        {
            if (value > 0 && value <= 360)
            {
                VelMax = value;
            }
            else
            {
                VelMax = 360;
            }
        }
    }
    public Carro()
    {
        VelMax = 260;
    }
}

class Program
{
    static void Main()
    {
        Carro c1 = new Carro();
        c1.VM = 220;
        Console.WriteLine("Velocidade máxima: {0}", c1.VM);
    }
}