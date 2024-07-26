using CalculosGeometrica.Modelos;

internal class Triangulo : Menu
{
    public override void Executar()
    {
        base.Executar();

        ExibirTitulo("Calculo do triângulo");

        Console.Write("Digite\nBase: ");
        double baseQuadrado = Convert.ToDouble(Console.ReadLine()); ;

        Console.Write("Altura: ");
        double alturaQuadrado = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"A área do triângulo é : {((baseQuadrado * alturaQuadrado) / 2).ToString("F")}cm.");
        Console.WriteLine("Digite qualquer tecla para voltar");
        Console.ReadKey();
    }
}