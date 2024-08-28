using System;

namespace ValueTypeReferenceType
{
    class Program
    {
        public static void Main()
        {
            // Tipos de valor
            int x = 10;
            int y = x;   // 'y' recebe uma cópia do valor de 'x'. Agora, 'y' também armazena o valor 10.

            Console.WriteLine(x); // Exibe 10 - o valor original de 'x'
            Console.WriteLine(y); // Exibe 10 - a cópia do valor de 'x' em 'y'

            x = 40;  // Alterando o valor de 'x' para 40.
            Console.WriteLine(x); // Exibe 40 - o novo valor de 'x'
            Console.WriteLine(y); // Exibe 10 - 'y' ainda contém o valor antigo (10), pois é uma cópia independente

            // Tipos de referência
            var array = new string[2];  // 'array' é um array de strings, um tipo de referência. Armazena uma referência para o array na memória.
            array[0] = "item 1";  // Define o valor do primeiro elemento do array para "item 1".

            var array2 = array;  // 'array2' recebe a mesma referência que 'array'. Ambos apontam para o mesmo array na memória.

            Console.WriteLine(array[0]);  // Exibe "item 1" - o valor do primeiro elemento do array original.
            Console.WriteLine(array2[0]); // Exibe "item 1" - o valor do primeiro elemento do mesmo array referenciado por 'array2'.

            array[0] = "item 2";  // Altera o valor do primeiro elemento do array para "item 2".
            Console.WriteLine(array[0]);  // Exibe "item 2" - o valor atualizado no array.
            Console.WriteLine(array2[0]); // Exibe "item 2" - como 'array2' e 'array' referenciam o mesmo array, a mudança é refletida em ambos.
        }
    }
}
