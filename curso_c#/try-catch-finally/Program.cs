using System;




class Area
{
    public static float Quadrado(float bas, float alt)
    {
        if (bas == 0 || alt == 0)
        {
            throw new Exception("Base ou altura não podem ser igual a 0");
        }
        return bas * alt;
    }
}


class Program
{
    static void Main(string[] args)
    {

        int num, num2, res;
        num = 10;
        num2 = 0; 
        try
        {
            res = num / num2;
            Console.WriteLine("{0} / {1} = {2}", num, num2, res);
        }
        catch (Exception err)
        {
            Console.WriteLine("Erro completo: {0}", err);
            Console.WriteLine("Tipo do erro: {0}", err.GetType());
            Console.WriteLine("Mensagem do erro: {0}", err.Message);
            Console.WriteLine("Local do erro: {0}", err.Source);
        }
        finally
        {
            Console.WriteLine("Fim do processo");
        }

        Console.WriteLine("-------------------------------------------------------------");

        // Outro Ex:

        float area = 0;
        try
        {
            area = Area.Quadrado(10, 0);
            Console.WriteLine("A área do quadrado é: {0}", area);
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message); // Mensagem do erro do método Quadrado
        }
    }
}
