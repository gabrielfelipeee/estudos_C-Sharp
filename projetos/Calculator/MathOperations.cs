namespace Calculator
{
    public class MathOperations : IMathOperations
    {
        public double Divisao(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }

        public double Multiplicacao(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }

        public double Adicao(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
        public double Subtracao(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
