using System;


// A ordem da execução vai ser primeiro a base, depois as derivadas

class Base{
    public Base()
    {
        Console.WriteLine("Construtor  da classe Base");
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor  da classe Derivada1");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor  da classe Derivada2");
    }
}

class Program
{
    static void Main()
    {
        Base base1 = new Base();
        Console.WriteLine("--------------------------------");
        Derivada1 derivada1 = new Derivada1();
        Console.WriteLine("--------------------------------");
        Derivada2 derivada2 = new Derivada2();
    }
}