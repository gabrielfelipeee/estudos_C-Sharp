using System;

class Veiculo
{
    private int Rodas;
    public int VelMax;
    private bool Ligado;
    
    public void Ligar()
    {
        Ligado = true;
    }
    public void Desligar()
    {
        Ligado = false;
    }
    public int GetRodas()
    {
        return Rodas;
    }
    public string GetLigado()
    {
        return Ligado ? "Sim" : "Não";
    }


    public Veiculo(int rodas)
    {
        Rodas = rodas;
    }


}



// Classe Carro (derivada) herdando a classe Veiculo (base)
class Carro : Veiculo
{
    public string Nome;
    public string Cor;
                                 // argumento do método construtor da classe base, número de rodas
    public Carro(string nome) : base(4)
    {
        Desligar();
        VelMax = 120;
        Cor = "Preto";
        Nome = nome;
    }
}

// Agora o classe Carro é base de CarroCombate
class CarroCombate : Carro
{
    public int Municao;
    public CarroCombate() : base("Tanque")
    {
        Municao = 100;
        Cor = "Verde";
        VelMax = 80;
        Ligar();
    }
}

class Program
{


    static void Main()
    {
        Carro c1 = new Carro("Civic");

        Console.WriteLine("Nome.............: {0}", c1.Nome);
        Console.WriteLine("Cor..............: {0}", c1.Cor);
        Console.WriteLine("Rodas............: {0}",c1.GetRodas());
        Console.WriteLine("Velocidade máxima: {0}", c1.VelMax);
        Console.WriteLine("Ligado...........: {0}\n", c1.GetLigado());



        CarroCombate c2 = new CarroCombate();
        Console.WriteLine("Nome.............: {0}", c2.Nome);
        Console.WriteLine("Cor..............: {0}", c2.Cor);
        Console.WriteLine("Rodas............: {0}", c2.GetRodas());
        Console.WriteLine("Velocidade máxima: {0}", c2.VelMax);
        Console.WriteLine("Ligado...........: {0}", c2.GetLigado());
    }
}