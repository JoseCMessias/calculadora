using System.Globalization;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor");
        var a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o segundo valor");
        var b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.WriteLine("Digite a operação ( + ou - ou * ou / )");
        var s = Console.ReadLine();


        Func<double, double, double> func = null;
        switch (s)
        {
            case "+":
                func = Somar;
                break;
            case "-":
                func = Subtracao;
                break;
            case "*":
                func = Multiplicacao;
                break;
            case "/":
                func = Divisao;
                break;
            default:
                break;
        }
        var resultado = Calcular(func, a, b);
        Console.WriteLine($"Resultado = {resultado.ToString("F2", CultureInfo.InvariantCulture)}");

    }
    static double Somar(double a, double b) => a + b;
    static double Subtracao(double a, double b) => a - b;
    static double Multiplicacao(double a, double b) => a * b;
    static double Divisao(double a, double b) => a / b;
    static double Calcular(Func<double, double, double> func, double a, double b) => func(a, b);
}