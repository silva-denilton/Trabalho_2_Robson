using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Robson_2
{
    public abstract class Forma
    {
        public double area;
        public double perimetro;
        

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

    }
}