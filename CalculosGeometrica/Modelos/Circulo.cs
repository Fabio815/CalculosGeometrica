
using CalculosGeometrica.Modelos;

public class Circulo : IFormas
{
    public Circulo(double raio)
    {
        Raio = raio;
    }

    public double Raio { get; }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }

    public double CalcularArea()
    {
        return Math.Pow(Raio, 2) * Math.PI;
    }
}