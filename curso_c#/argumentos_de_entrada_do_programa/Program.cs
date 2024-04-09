using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine("Qtde de argumentos: {0}", args.Length);
            for (int i = 0; i <= args.Length; i++)
            {
                Console.WriteLine("Argumento {0}: {1}", i + 1, args[i]);
            }
        }
        else
        {
            Console.WriteLine("Não foi passado argumento");
        }
    }
}
