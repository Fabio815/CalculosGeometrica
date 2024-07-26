using CalculosGeometrica.Modelos;

internal class Quadrado : Menu
{
    public void Executar()
    {
        base.Executar();

        ExibirTitulo("Calculo do quadrado");

        Console.Write("Digite\nBase: ");
        double baseQuadrado = Convert.ToDouble(Console.ReadLine());

        Console.Write("Altura: ");
        double alturaQuadrado = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"A área do quadradro é : {(baseQuadrado * alturaQuadrado).ToString("F")}cm.");
        Console.WriteLine("Digite qualquer tecla para voltar");
        Console.ReadKey();
    }
}