using CalculosGeometrica.Modelos;


void MenuPrincipal()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções: \n1 - Quadrado\n2 - Triângulo\n3 - Círculo\n4 - Sair");
    Console.Write("Opcão: ");
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Quadrado quadrado = new();
            quadrado.Executar();
            MenuPrincipal();
            break;
        case 2:
            Triangulo triangulo = new Triangulo();
            triangulo.Executar();
            MenuPrincipal();
            break;
        case 3:
            Circulo circulo = new Circulo();
            circulo.Executar();
            MenuPrincipal();
            break;
        case 4:
            Console.WriteLine("Saindo...");
            Thread.Sleep(2000);
            break;
        default:
            Console.WriteLine("Opção inválida");
            MenuPrincipal();
            break;
    }
}

MenuPrincipal();