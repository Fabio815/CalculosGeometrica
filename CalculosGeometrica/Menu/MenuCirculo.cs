namespace CalculosGeometrica.Menu
{
    internal class MenuCirculo : Menu
    {
        public override void Executar()
        {
            base.Executar();
            ExibirTitulo("Calculo do círculo");
            Console.WriteLine("Digite o raio do círculo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Circulo circulo = new(raio);

            Console.WriteLine($"A área do círculo é {circulo.CalcularArea().ToString("F")}cm");
            Console.WriteLine($"O perímetro do círculo é {circulo.CalcularPerimetro().ToString("F")}cm");
            Console.WriteLine("Digite qualquer tecla para voltar");
            Console.ReadKey();
        }
    }
}
