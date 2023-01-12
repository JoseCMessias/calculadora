using System.Globalization;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor");
        var a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o segundo valor");
        var b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite a operação ( + ou - ou * ou / )");
        var s = Console.ReadLine();


        Func<float, float, float> func = null;
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
    static float Somar(float a, float b) => a + b;
    static float Subtracao(float a, float b) => a - b;
    static float Multiplicacao(float a, float b) => a * b;
    static float Divisao(float a, float b) => a / b;
    static float Calcular(Func<float, float, float> func, float a, float b) => func(a, b);
}