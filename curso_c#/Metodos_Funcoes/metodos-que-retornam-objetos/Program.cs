using System;


class Galinha
{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    // Método que retorna um ovo
    // acesso: public    tipo: Ovo  nome: botarOvo
    public Ovo BotarOvo()
    {
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo
{
    private int numOvos;
    private string galinha;
    public Ovo(int numOvo, string galinha)
    {
        numOvos = numOvo;
        this.galinha = galinha;
        Console.WriteLine("A galinha {0} botou {1} ovo(s)", this.galinha, this.numOvos);
    }
}

class Program
{ 
    static void Main()
    {
        Galinha g1 = new Galinha("Ginger");
        Galinha g2 = new Galinha("Rocky");
        Galinha g3 = new Galinha("Molly");
        g1.BotarOvo();

        g3.BotarOvo();
    }
}
