using CalculosGeometrica.Modelos;

internal class Triangulo : Menu
{
    public override void Executar()
    {
        base.Executar();

        ExibirTitulo("Calculo do triângulo");

        Console.Write("Digite\nBase: ");
        int baseQuadrado = int.Parse(Console.ReadLine());

        Console.Write("Altura: ");
        int alturaQuadrado = int.Parse(Console.ReadLine());

        Console.WriteLine($"A área do triângulo é : {(baseQuadrado * alturaQuadrado) / 2}cm.");
        Console.WriteLine("Digite qualquer tecla para voltar");
        Console.ReadKey();
    }
}