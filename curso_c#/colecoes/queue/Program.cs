using System;

/*
FIFO (First In, First Out): Em uma fila, o primeiro elemento a ser adicionado é o primeiro a ser removido.
Usada quando você precisa processar itens na ordem em que foram adicionados.
*/


class Queue
{
    static void Main()
    {
        Queue<string> veiculos = new Queue<string>();

        // Adicionar
        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Bike");

        // Remover
        veiculos.Dequeue(); // Carro foi removido (o primeiro elemento a ser adicionado é o primeiro a ser removido). Moto passou a ser o primeiro

        // Retorna o primeiro elemento, mas não exclui
        Console.WriteLine(veiculos.Peek());
    }
}