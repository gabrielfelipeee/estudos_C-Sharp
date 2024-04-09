using System;


// Um namespace é uma estrutura que organiza e agrupa um conjunto de classes, interfaces, enums e outros tipos relacionados em uma hierarquia lógica
namespace Calculos
{
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
}


namespace Exemplo
{
    class Classe
    {
        public static void Ex() { }
    }
}




class Program
{
    static void Main(string[] args)
    {

        float area = 0;
        try
        {
            // Para chamar, devemos informa o nomespace
            area = Calculos.Area.Quadrado(10, 0);
            Console.WriteLine("A área do quadrado é: {0}", area);
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message); // Mensagem do erro do método Quadrado
        }
    }
}
