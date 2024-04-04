using System;

class Out
{

    // out permite que o método retorne mais de um valor

    static void Main()
    {
        int rest; // O resto será armazenado nessa variável
        int quoc = Dividir(11, 2, out rest);

        Console.WriteLine("Resultado da divisão: {0}",quoc);
        Console.WriteLine("Resto da divisão: {0}",rest);
    }

    static int Dividir(int dividendo, int divisor, out int resto)
    {
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;

        return quociente;
    }

}