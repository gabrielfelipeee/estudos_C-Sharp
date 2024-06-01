using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> carros = new List<string>();
        List<string> carros2 = new List<string>();
        carros.Add("Camaro");
        carros.Add("Golf");
        carros.Add("Civic");
        carros.Add("Argo");
        carros.Add("Camaro");

        // AddRange adiciona uma serie de elementos.
        carros2.AddRange(carros); // Adicionando todos os elementos de carros a carros2

        // Contains verifica se está na lista, e retorna um bool
        Console.WriteLine(carros.Contains("Gol"));

        // Pegar o índice, se o elemento não existe, o retorno será -1
        Console.WriteLine(carros.IndexOf("Golf"));

        // Inserindo elementos em uma posição determinada
                 // índice, elemento
        carros.Insert(1, "Gol");

        // Retorna a posição do último elemento determinado
        Console.WriteLine(carros.LastIndexOf("Camaro"));

    }
}
