using CalculosGeometrica.Modelos;

internal class Quadrado : Menu
{
    public void Executar()
    {
        base.Executar();

        ExibirTitulo("Calculo do quadrado");

        Console.Write("Digite\nBase: ");
        int baseQuadrado = int.Parse(Console.ReadLine());

        Console.Write("Altura: ");
        int alturaQuadrado = int.Parse(Console.ReadLine());

        Console.WriteLine($"A área do quadradro é : {baseQuadrado * alturaQuadrado}cm.");
        Console.WriteLine("Digite qualquer tecla para voltar");
        Console.ReadKey();
    }
}