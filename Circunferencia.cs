using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Robson_2
{
    internal class Circunferencia : Forma
    {
        public double RaioC;
        public override void CalcularArea()
        {
            area =3.14159 * Math.Pow(RaioC, 2);
        }
        public override void CalcularPerimetro()
        {
            perimetro = 2 * 3.14159 * RaioC;
        }
    }
}
