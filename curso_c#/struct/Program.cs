using System;
using System.Runtime.InteropServices;

/*
Struct: Não pode herdar de outra struct ou classe, e nem pode ser herdada por outras structs ou classes.
Struct: Por padrão, todos os campos de uma struct devem ser inicializados em seu construtor.
Struct: Não suporta polimorfismo, pois não pode herdar de outras structs ou classes.
*/

struct Carro
{
    public string modelo;
    public string marca;
    public string cor;

    public Carro(string modelo, string marca, string cor)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.cor = cor;
    }




    
}

class Program
{
    static void Main()
    {
        // Criando um obj normal
        Carro c1 = new Carro("Civic", "Honda", "Preto");

        Console.WriteLine(c1.modelo);
        Console.WriteLine(c1.marca); 
        Console.WriteLine(c1.cor);

        Console.WriteLine("----------------------------------------------");

        // Criando um array de struct
        Carro[] cars = new Carro[3];

        cars[0].modelo = "HR-V";
        cars[0].marca = "Honda";
        cars[0].cor = "Azul";

        cars[1].modelo = "Golf";
        cars[1].marca = "Volkswagen";
        cars[1].cor = "Cinza";

        cars[2].modelo = "Camaro";
        cars[2].marca = "Chevrolet";
        cars[2].cor = "Branco";

        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine("\n{0}", cars[i].modelo);
            Console.WriteLine("Marca: {0}", cars[i].marca);
            Console.WriteLine("Cor: {0}", cars[i].cor);
        }
    }
}