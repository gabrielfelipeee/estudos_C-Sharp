using System;

class MatrizesBidimensionais
{
    static void Main()
    {


        // Declaração de uma Matriz de 3 linhas e 5 colunas
        int[,] numbers = new int[3, 5]; 

        /** 
         Representação da matriz acima:

          10 20 30 40 50
          11 13 14 15 45
          47 25 34 74 98


        **/

        numbers[0, 0] = 10; // Posição: índice 0 da linha e índice 0 da coluna
        numbers[0, 1] = 20; // Posição: índice 0 da linha e índice 1 da coluna
        numbers[0, 2] = 30; 
        numbers[0, 3] = 40;
        numbers[0, 4] = 50;

        numbers[1, 0] = 11;
        numbers[1, 1] = 13;
        numbers[1, 2] = 14;
        numbers[1, 3] = 15;
        numbers[1, 4] = 45;

        numbers[2, 0] = 47;
        numbers[2, 1] = 25;
        numbers[2, 2] = 34;
        numbers[2, 3] = 74;
        numbers[2, 4] = 98;

        Console.WriteLine(numbers[1, 4]);



        // Declarando e já iniciando uma matriz com
        //                                       linha 1                 linha 2
        string[,] names = new string[2, 2] {{"Gabriel", "Felipe"}, {"João", "Mário"}};
        Console.WriteLine(names[0,0]);
    }
}