using System;


/**
Métodos virtuais são métodos com o mesmo nome e assinatura
(tipos de parâmetros), mas podem ter implementações diferentes em classes derivadas
**/

class Base
{
    // Método virtual da classe base
    public virtual void Info()
    {
        Console.WriteLine("info Base");
    }
}

class Derivada1 : Base
{

    // O override serve para indicar que o método está subscrevendo o método virtual da classe base
    public override void Info()
    {
        Console.WriteLine("info Derivada1");
    }
}

class Derivada2 : Derivada1
{
    public override void Info()
    {
        Console.WriteLine("info Derivada2");
    }
}

class Program
{
    static void Main()
    {
        Base base1 = new Base();
        base1.Info();

        Console.WriteLine("--------------------------------");

        Derivada1 derivada1 = new Derivada1();
        derivada1.Info();

        Console.WriteLine("--------------------------------");

        Derivada2 derivada2 = new Derivada2();
        derivada2.Info();

        Console.WriteLine("--------------------------------");

        // Controlando qual método será chamado
        Base Ref;
        Ref = derivada2; // Nesse caso executa o método Info de Derivada2
        Ref.Info();
    }
}