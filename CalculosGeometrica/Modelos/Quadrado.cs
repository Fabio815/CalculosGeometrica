using CalculosGeometrica.Modelos;

internal class Quadrado : IFormas
{
    public Quadrado(double _base)
    {
        Base = _base;
    }

    public double Base { get; set; }

    public double CalcularArea()
    {
        return Base * Base;
    }

    public double CalcularPerimetro()
    {
        return 4 * Base;
    }
}