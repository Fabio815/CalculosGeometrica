using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosGeometrica.Menu;

internal class Menu
{
    public void ExibirTitulo(string titulo)
    {
        int contagem = titulo.Length;
        string asteriscos = string.Empty.PadLeft(contagem, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
    public virtual void Executar()
    {
        Console.Clear();
    }
}