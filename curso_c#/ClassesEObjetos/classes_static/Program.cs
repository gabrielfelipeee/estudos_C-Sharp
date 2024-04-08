using System;


// Não pode ser instânciada, propriedades e métodos devem ser static

/**
As classes estáticas são usadas principalmente quando você
deseja agrupar métodos relacionados ou fornecer
funcionalidades utilitárias que não dependem do estado de instância.
**/

public static class MathUtils {
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) / 1.8;
        return Math.Round(celsius, 2);
    }

}

class Program
{
    static void Main()
    {
        // Usando métodos de classes estáticas
        Console.WriteLine(MathUtils.FahrenheitToCelsius(100));

    }
}