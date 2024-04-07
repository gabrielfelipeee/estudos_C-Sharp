using System;

class MetodosArrays
{
    static void Main()
    {
        int[] array1 = new int[5] { 11, 452, 12, 10, 80 };
        int[] array2 = new int[5];
        int[] array3 = new int[5];

        int[,] matriz = new int[2,5] {{ 10, 20, 30, 40, 50 }, { 60, 70, 80, 90, 100 }};

        // BinarySearch(array, valor) => retorna a posição do elemento procurado,
        int elementoProcurado = Array.BinarySearch(array1, 10);
        Console.WriteLine("BinarySearch: {0}", elementoProcurado); // Índice 3
        Console.WriteLine("\n----------------------------------");


        // Copy(Ar_Origem, Ar_destino, qtde_elementos) => Faz a cópia de elementos de um array para outro
        Array.Copy(array1, array2, array3.Length);
        Console.Write("Copy: ");
        foreach (var item in array2)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n----------------------------------");


        // Array_Origem.CopyTo(Ar_destino, a_partir_desta_posição)
        array1.CopyTo(array3, 0);
        Console.Write("CopyTo: ");
        foreach(var item in array3)
        {
            
            Console.Write(item + " ");
        }
        Console.WriteLine("\n----------------------------------");


        // array.GetLowerBound(dimensão) => retorna o menor índice de um array
        // Normalmente sempre será o 0
        int menorIndice = array3.GetLowerBound(0);
        int menorIndiceMatriz = matriz.GetLowerBound(1);
        Console.WriteLine("GetLowerBound: {0}", menorIndice);
        Console.WriteLine("GetLowerBound na Matriz: {0}", menorIndiceMatriz);
        Console.WriteLine("\n----------------------------------");


        // array.GetUpperBound(dimensão) => retorna o maior índice de um array 
        int maiorIndice = array3.GetUpperBound(0);
        Console.WriteLine("GetUpperBound: {0}", maiorIndice);
        Console.WriteLine("\n----------------------------------");


        // GetValue(índice) => Retorna um valor específico
        int valor1 = Convert.ToInt32(array1[0]);
        int valor2 = Convert.ToInt32(matriz[0, 2]);
        Console.WriteLine("GetValue: {0}", valor1);
        Console.WriteLine("GetValue em matriz: {0}", valor2);
        Console.WriteLine("\n----------------------------------");


        // IndexOf(array, valor) => retorna o índice do primeiro valor encontrado correspondente 
        int indice1 = Array.IndexOf(array1, 10);
        Console.WriteLine("IndexOf: {0}", indice1);
        Console.WriteLine("\n----------------------------------");

        // LastIndexOf => Caso tenha valores repstidos, o last retorna o índice do último


        // Sort(array) => Ordenar
        Array.Sort(array1);
        Console.Write("Sort: ");
        foreach(var item in array1)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n----------------------------------");
    }
}