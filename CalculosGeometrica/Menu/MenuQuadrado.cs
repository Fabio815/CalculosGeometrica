namespace CalculosGeometrica.Menu
{
    internal class MenuQuadrado : Menu
    {
        public void Executar()
        {
            base.Executar();

            ExibirTitulo("Calculo do quadrado");

            Console.Write("Digite\nLado: ");
            double baseQuadrado = Convert.ToDouble(Console.ReadLine());

            Quadrado quadrado = new Quadrado(baseQuadrado);

            Console.WriteLine($"A área do quadradro é : {quadrado.CalcularArea().ToString("F")}cm.");
            Console.WriteLine($"O perímetro do quadrado é {quadrado.CalcularPerimetro().ToString("F")}cm");
            Console.WriteLine("Digite qualquer tecla para voltar");
            Console.ReadKey();
        }
    }
}
