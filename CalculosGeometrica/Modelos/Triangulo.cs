using CalculosGeometrica.Modelos;

internal class Triangulo : IFormas
{
    public Triangulo(double _base, double altura)
    {
        Altura = altura;
        Base = _base;
    }
    public double Base { get; set; }
    public double Altura { get; set; }

    public double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
    public double CalcularPerimetro()
    {
        return Altura * 2 + Base;
    }
}