using System.Diagnostics;

namespace Cronometro
{
    public class Program
    {
        static void Main()
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Quanto tempo você deseja contar?");
            Console.WriteLine("s = Segundo | Ex: 10s");
            Console.WriteLine("m = Minuto | Ex: 2m");

            string data = Console.ReadLine().ToLower();
            if (!data.Contains("s") || !data.Contains("m"))
            {
                Console.WriteLine("Dados inválidos!");
            }

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            switch (type)
            {
                case 's':
                    PreStart(time);
                    break;
                case 'm':
                    PreStart(time * 60);
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);
            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = time;

            while (currentTime >= 0)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime--;
                Thread.Sleep(1000);
            }
        }
    }
}
