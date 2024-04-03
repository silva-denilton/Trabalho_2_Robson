using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Robson_2
{
    internal class Hexagono : Forma
    {
        public double Complado_H;


        public override void CalcularArea()
        {
            double areat = Math.Pow(Complado_H, 2) * Math.Sqrt(3) / 4;
            area = areat * 6;
        }

        public override void CalcularPerimetro()
        {
            perimetro = Complado_H * 6;
        }
    }
}
