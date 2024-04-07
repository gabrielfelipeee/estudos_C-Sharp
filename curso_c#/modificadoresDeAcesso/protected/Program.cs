using System;

class Veiculo
{
    public int VelAtual;
    private int VelMax;
    protected bool Ligado;

    public int GetVelMax()
    {
        return VelMax;
    }
    public string GetLigado()
    {
        return Ligado ? "Sim" : "Não";
    }
    public Veiculo(int velMax)
    {
        VelAtual = 0;
        VelMax = velMax;
        Ligado = false;
    }
}

class Carro : Veiculo
{
    public string Nome;

    public Carro(string nome, int velMax) : base(velMax)
    {
        Nome = nome;
        Ligado=true;
    }
}

class Program
{
    static void Main()
    {
        Carro c1 = new Carro("Camaro", 260);

        Console.WriteLine(c1.Nome);
        Console.WriteLine(c1.GetLigado());
        Console.WriteLine(c1.VelAtual);
        Console.WriteLine(c1.GetVelMax());
    }
}