using Microsoft.VisualBasic;
using System;

namespace PremierLeague
{
    class Clube
    {
        public string Nome { get; set; }
        public string Estadio { get; set; }
        public int AnoFundacao { get; set; }
        public int QtdTitulos { get; set; }
        public bool EhBigSix { get; set; }


        // Método construtor:
        // Mesmo nome da sua classe
        // Vai ser chamado em cada instância de objeto
        public Clube(string nome, string estadio)
        {
            Nome = nome;
            Estadio = estadio;
        }

        // Método destrutor:
        // Mesmo nome da sua classe com um ~ antes
        // Vai ser chamado pelo Garbage Collection sempre que um objeto for destruído 
        ~Clube()
        {
            Console.WriteLine("O clube foi destruído");
        }


        public void MostrarInfo()
        {
            Console.Write("\nO {0} têm {1} títulos de premier league", this.Nome, this.QtdTitulos);

            if (EhBigSix)
            {
                Console.Write(", é considerado um dos 6 maiores clubes da Inglaterra\n" );
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Objeto com os valores dos argumentos do método construtor

            Clube clube = new Clube("Liverpool", "Anfield"); // O new serve para reservar memória para o objeto
            clube.QtdTitulos = 19;
            clube.AnoFundacao = 1982;
            clube.EhBigSix = true;
            clube.MostrarInfo();

            Clube clube2 = new Clube("Man United", "Old Trafford");
            clube2.QtdTitulos= 20;
            clube2.AnoFundacao = 1878;
            clube2.EhBigSix = true;
            clube2.MostrarInfo();

            Clube clube3 = new Clube("Brighton", "Falmer Stadium");
            clube3.QtdTitulos = 0;
            clube3.AnoFundacao = 1901;
            clube3.EhBigSix = false;
            clube3.MostrarInfo();
        }
    }
}