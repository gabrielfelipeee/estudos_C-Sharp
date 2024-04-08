using System;


/**
Uma classe abstrata é uma classe que não pode ser instanciada diretamente. 
Ela é projetada para ser herdada por outras classes, que então podem fornecer 
implementações concretas para os métodos abstratos definidos na classe abstrata.
**/

abstract class Veiculo // Classe Base Abstrata
{
    protected int VelMax;
    protected int VelAtual;
    protected bool Ligado;
    public Veiculo()
    {
        VelAtual = 0;
        Ligado = false;
    }

    public void SetLigado(bool ligado)
    {
        Ligado = ligado;
    }


    // Método abstrato, todas as classes derivadas de Veiculo devem implementá-lo.
    abstract public void Aceleracao(int mult);
}

class Carro : Veiculo
{
    public Carro()
    {
        VelMax = 160;
    }


    // Implentação do método abstrato
    public override void Aceleracao(int mult)
    {
        VelAtual += 10 * mult;
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro();
        carro.Aceleracao(2);
    }
}
