using System;

class Arrays
{
    static void Main()
    {
        // Declaração de um array de 5 elementos vazio. índices 0 a 4
        int[] numbers = new int[5]; 
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;
        Console.WriteLine(numbers[0]);



        // Declarando e já iniciando um array com valores
        string[] bigSix = new string[6] { "Liverpool", "Man United", "Chelsea", "Arsenal", "Tottenham", "Man City" };
        Console.WriteLine(bigSix[0]);



        // Declarando um array sem especificar o tamanho
        int[] nums = { 100, 200, 400, 540, 955, 558 };


        string[] theTwoBigs = { "Liverpool", "Man United"};
    }
}