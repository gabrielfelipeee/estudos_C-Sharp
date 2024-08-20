// System.IO

using System.Text;

namespace systemio
{
    public class Program
    {
        public static void Main()
        {
            string texto = "Meu texto";
            // Método WriteAllText -> Cria um arquivo chamado arquivo.txt (nesse caso), e coloca o conteúdo dentreo dele. Se o arquivo já existe, será substituído. O Valor deve ser uma string
            File.WriteAllText("arquivo.txt", texto);


            // Método WriteAllLines -> Mesma coisa, mas aceita um array de strings, onde cada um ficará em umaa linha
            string[] linhas = { "Linha 1", "Linha 2", "Linha 3" };
            File.WriteAllLines("lines.txt", linhas);



            // Método WriteAllBytes -> Grava um array de bytes no arquivo
            string texto2 = "String string string";
            byte[] bytes = Encoding.UTF8.GetBytes(texto2); // Converte a string em um array de bytes
            File.WriteAllBytes("texto.txt", bytes);



            // Lendo arquivos com o método ReadAllText

            string txt = File.ReadAllText("arquivo.txt");
            Console.WriteLine(txt);
        }
    }
}
