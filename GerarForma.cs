using System.Globalization;

namespace Atividades_Robson_2
{
    internal class GerarForma
    {

        public void Solicitarforma()
        {
            int forma;

            Console.WriteLine("Digite (1) para Quadrado: ");
            Console.WriteLine("Digite (2) para Triangulo: ");
            Console.WriteLine("Digite (3) para Circunferencia: ");
            Console.WriteLine("Digite (4) para hexagono: ");
            forma = int.Parse(Console.ReadLine());
            if (forma == 1)
            {
                Quadrado _quadrado = new Quadrado();
                Console.WriteLine("Digite o lado: ");
                _quadrado.lado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                _quadrado.CalcularPerimetro();
                _quadrado.CalcularArea();
                Console.WriteLine("A area do Quadrado é: " + _quadrado.area.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("O perimero do Quadrado é: " + _quadrado.perimetro.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (forma == 2)
            {
                Triangulo _triangulo = new Triangulo();
                Console.WriteLine("Digite o lado 1: ");
                _triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Digite o lado 2");
                _triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Digite o lado 2");
                _triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                _triangulo.CalcularArea();
                _triangulo.CalcularPerimetro();
                Console.WriteLine("A area do triangulo é: " + _triangulo.area.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("O perimetro do triangulo é: " + _triangulo.perimetro.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (forma == 3)
            {
                Circunferencia _circunferencia = new Circunferencia();
                Console.WriteLine("informe o raio: ");
                _circunferencia.RaioC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                _circunferencia.CalcularArea();
                _circunferencia.CalcularPerimetro();
                Console.WriteLine("A area da Circunferencia é " + _circunferencia.area.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("O perimero da Circunferencia é " + _circunferencia.perimetro.ToString("F2"), CultureInfo.InvariantCulture);
            }
            else if (forma == 4)
            {
                Hexagono _hexagono = new Hexagono();
                Console.WriteLine("Digite o comprimento do lado do Hexagono: ");
                _hexagono.Complado_H = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                _hexagono.CalcularArea();
                _hexagono.CalcularPerimetro();
                Console.WriteLine("A area do Hexagono é " + _hexagono.area.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("O perimero do Hexagono é " + _hexagono.perimetro.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Opção invalida:");
            }
        }
    }
}

