using System;

class Metodos
{
    static void Main()
    {
        Fibonacci(13);

        Console.WriteLine(Soma(10, 15));

    }


    // Métodop que não retorna nada, void.
    static void Fibonacci(int num)
    {
        int previous = 0;
        int current = 1;
        bool control = false;

        while (current <= num)
        {
            if (current == num)
            {
                Console.WriteLine("{0} Pertence a sequência Fibonacci", num);
                control = true;
                break;
            }
            else
            {
                int next = current + previous;
                previous = current;
                current = next;
            }
        }

        if (!control)
        {
            Console.WriteLine("{0} não pertence a sequência Fibonacci", num);
        }
    }


    static int Soma(int num1,int num2)
    {
        int res = num1 + num2;
        return res;
    }
}
