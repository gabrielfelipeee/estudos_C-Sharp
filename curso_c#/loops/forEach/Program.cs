using System;

class ForEach
{
    static void Main()
    {
        string[] bigSix = new string[6] { "Liverpool", "Man United", "Chelsea", "Arsenal", "Tottenham", "Man City" };

        foreach (string item in bigSix)
        {
            Console.WriteLine(item); // Imprime cada elemento 
        }

    }
}