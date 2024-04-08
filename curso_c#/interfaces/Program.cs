using System;


/**
interface define um contrato contendo métodos, propriedades,
eventos ou outros membros que devem ser implementados pelas classes que a usam/herdam.
**/
interface IVeiculo
{
    void Ligar();
    void Desligar();
    void Info();
    bool Ligado { get; set; }
}

interface ICombate
{
    public void Disparar();
}


// Essa classe deve ter todos os métodos propriedades da interface IVeiculo
class Carro : IVeiculo 
{
    private bool ligado;
    public bool Ligado
    { 
        get
        {
            return ligado;
        }
        set
        {
            ligado = value;
        }
    }


    public void Ligar()
    {
        ligado = true;
    }
    public void Desligar()
    {
        ligado = false;
    }
    public void Info() { 
        if (ligado)
        {
            Console.WriteLine("O carro está Ligado");
        } else
        {
            Console.WriteLine("O carro está Desligado");
        }
    }
}


// Classe usando 2 interfaces
class CarroDeCombate : IVeiculo, ICombate
{
    public void Ligar() { }
    public void Desligar() { }
    public void Info() { }
    public bool Ligado { get; set; }

    public void Disparar() { }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro();
        carro.Ligado = true;
        carro.Info();
    }
}