
using CalculosGeometrica.Modelos;

internal class Circulo : Menu
{
    public override void Executar()
    {
        base.Executar();
        ExibirTitulo("Calculo do círculo");
        Console.WriteLine("Digite o raio do círculo: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double area = Math.Pow(raio, 2) * Math.PI;

        Console.WriteLine($"A área do círculo é {area.ToString("F")}cm");
        Console.WriteLine("Digite qualquer tecla para voltar");
        Console.ReadKey();
    }
}