using System;
/*
Os métodos e variáveis estáticas são associados à classe em vez de a uma instância específica da classe. Isso significa que eles pertencem à classe em si, não a objetos individuais criados a partir dela. 
*/


class Math
{
    public static double pi = 3.14;

    public static int Dobro(int num) {
        return num * 2;
    }
}

class Program
{
    static void Main(string[] args)
    {

        // Usando variáveis e métodos static sem precisar declarar um objeto
        double vpi = Math.pi;
        int number = Math.Dobro(5);

        Console.WriteLine(vpi);
        Console.WriteLine(number);

    }
}