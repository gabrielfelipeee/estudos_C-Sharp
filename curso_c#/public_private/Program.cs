using System;
using System.Runtime.InteropServices.Marshalling;

class Jogador
{
    private string Nome;
    private int Energia;

    public Jogador(string Nome)
    {
        this.Nome = Nome;
        Energia = 100;
    }


    // Com as propriedades privadas não podemos acesssar fora de sua classe, mas podemos criar métodos para isso.
    public int GetEnergia()
    {
        return Energia;
    }
    public int SetEnergia(int energia)
    {
        if (energia <= 0)
        {
            Energia = 0;
        }
        else if (energia > 0 && energia <= 100)
        {
            Energia = energia;
        }
        else
        {
            Energia = 100;

        }
        return Energia;
    }

    public string GetNome()
    {
        return Nome;
    }
}

class Program
{
    static void Main()
    {
        Jogador player1 = new Jogador("Manel");
        Console.WriteLine("Nome: {0}", player1.GetNome());
        Console.WriteLine("Energia: {0}", player1.SetEnergia(180));
    }
}
