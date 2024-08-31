namespace Calculator
{
    class Calculator
    {
        public static void Calcular()
        {
            var mathOperations = new MathOperations();

            
            Console.Clear();
            Console.Write("Escolha uma opção: [1] Adição | [2] Subtração | [3] Multiplicação | [4] Divisão: ");
            int operation = int.Parse(Console.ReadLine().ToString());

            if (operation < 1 || operation > 4)
            {
                Console.Clear();
                Console.WriteLine("Operação inválida");
                return;
            }

            Console.WriteLine("Digite o primeiro valor");
            double firstNumber = double.Parse(Console.ReadLine().ToString());

            Console.WriteLine("Digite o segundo valor");
            double secondNumber = double.Parse(Console.ReadLine().ToString());

            double result = 0;
            switch (operation)
            {
                case 1:
                    result = mathOperations.Adicao(firstNumber, secondNumber);
                    break;
                case 2:
                    result = mathOperations.Subtracao(firstNumber, secondNumber);
                    break;
                case 3:
                    result = mathOperations.Multiplicacao(firstNumber, secondNumber);
                    break;
                case 4:
                    result = mathOperations.Divisao(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
            Console.Clear();
            Console.WriteLine("O resultado é {0}", result);
        }
    }
}
