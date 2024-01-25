class Music {
    public string name;
    public string artist;
    public int duratioin;
    public bool available;

    public void DisplayTechnicalSheet()
    {
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Artista: {artist}");
        Console.WriteLine($"Duração: {duratioin}");
        if (available)
        {
            Console.WriteLine("Disponível!");
        } else
        {
            Console.WriteLine("Adquire o plano plus!");
        }
    }
}