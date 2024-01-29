class Music {
    public string Name { get; set; } // get: leitura | set: escrita
    public string Artist { get; set; }
    public int Duratioin { get; set; }
    public bool Available { get; set; }

    // Essa propriedade é somente leitura
    public string ShortDescription  
    {
        get
        {
            return $"A musica {Name} pertence a {Artist}";
        }
    }
    // Pode ser resumida para: public string ShortDescription => $"A musica {Name} pertence a {Artist}"


    public void DisplayTechnicalSheet()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Artist}");
        Console.WriteLine($"Duração: {Duratioin}");

        if (Available)
        {
            Console.WriteLine("Disponível!");
        } else
        {
            Console.WriteLine("Adquire o plano plus!");
        }
    }
}
