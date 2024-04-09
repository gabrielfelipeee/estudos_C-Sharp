using System;
using System.Collections.Generic; // Biblioteca de coleções genéricas

/*
Um dicionário é uma estrutura de dados que armazena pares de chave-valor. 
Cada chave é única dentro do dicionário e é usada para acessar o valor correspondente. 

Ex: Um dicionário de pessoas
CPF seria a chave => único
Nome da pessoa seria o valor
*/


class Program
{
    static void Main()
    {
        // Criando do dictionary
        Dictionary<int, string> veiculos = new Dictionary<int, string>();


        // Adicionando elementos chave e valor, de acordo com o tipo declarado
        veiculos.Add(1, "Carro");
        veiculos.Add(2, "Avião");
        veiculos.Add(3, "Moto");
        veiculos.Add(4, "Bicicleta");

        veiculos[2] = "Navio"; // Alterando o valor da chave 2


        // Imprimindo os valores e chaves de um dictionary
        Console.WriteLine("Usando KeyValuePair<TKey, TValue>: ");
        foreach (KeyValuePair<int, string> veiculo in veiculos)
        {
            Console.WriteLine("A chave do veiculo {0} é {1}", veiculo.Value, veiculo.Key);
        }


        Console.WriteLine("--------------------------------");


        Console.WriteLine("Usando ValueCollection: ");

        Dictionary<int, string>.ValueCollection valoresDeVeiculos = veiculos.Values;

        foreach (string veiculo in valoresDeVeiculos)
        {
            Console.WriteLine(veiculo);
        }


        //  Outros métodos
        veiculos.ContainsKey(5); // Verifica se uma chave existe, retorna true ou false
        veiculos.ContainsValue("Navio"); // Verifica se um valor existe, retorna true ou false

        veiculos.Remove(1); // Exclui um elemento
        veiculos.Clear(); // Limpa o dictionary (exclui todos os elementos)

    }
}