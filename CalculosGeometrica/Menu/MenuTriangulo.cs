namespace CalculosGeometrica.Menu
{
    internal class MenuTriangulo : Menu
    {
        public override void Executar()
        {
            base.Executar();

            ExibirTitulo("Calculo do triângulo");

            Console.Write("Digite\nBase: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine()); ;

            Console.Write("Altura: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            Triangulo triangulo = new(baseTriangulo, alturaTriangulo);

            Console.WriteLine($"A área do triângulo é : {triangulo.CalcularArea().ToString("F")}cm.");
            Console.WriteLine($"O perímetro do triângulo é : {triangulo.CalcularPerimetro().ToString("F")}cm.");
            Console.WriteLine("Digite qualquer tecla para voltar");
            Console.ReadKey();
        }
    }
}
