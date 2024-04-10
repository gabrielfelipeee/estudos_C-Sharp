using System;
using System.Collections.Generic; // Biblioteca de coleções genéricas

/*
 É uma lista encadeada. Uma lista encadeada é uma coleção de elementos onde cada elemento, além de armazenar um valor, também mantém uma referência (ou ponteiro) para o próximo elemento na lista.

 Cada elemento na lista é um nó
 */


class Program
{
    static void Main()
    {
        LinkedList<string> animais = new LinkedList<string>();



        // Com o AddFirst o último elemento sempre será o primeiro, pois ele adiciona no início
        animais.AddFirst("Leão");
        animais.AddFirst("Gato");
        animais.AddFirst("Puma");
        animais.AddFirst("Cavalo");

        // adiciona no final
        animais.AddLast("Vaca");


        // Adiciona depois de um elemento
        LinkedListNode<string> no;
        no = animais.FindLast("Cavalo"); // Encontra  o último nó que tem o valor Cavalo
        animais.AddAfter(no, "Égua");

        // Adiciona antes
        animais.AddBefore(no, "Rato");

        animais.Find("Gato"); // Verifica se um elemento está no linkedlist


        foreach (string animal in animais)
        {
            Console.WriteLine(animal);
        }

        animais.RemoveFirst(); // Remove o primeiro
        animais.RemoveLast(); // Remove o último
        animais.Remove("Vaca"); // Remove um elemento
        animais.Clear(); // Remove todos os elementos

    }
}