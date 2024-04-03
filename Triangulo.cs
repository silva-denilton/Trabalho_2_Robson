using System;
namespace Atividades_Robson_2
{
    class Triangulo : Forma
    {
        public double A, B, C, P;
        public override void CalcularArea()
        {
            if (A == B && B == C)
            {
                area = A * B / 2;
            }
            else if (A != B && B != C)
            {
                P = A + B + C / 2;
                area = Math.Pow(P * (P - A) * (P - B) * (P - C), 2);
            }
            else if (A == B && B != C)
            {
                P = Math.Pow(A + B, 2);
            }
        }
        public override void CalcularPerimetro()
        {
            perimetro = A + B + C;
        }
    }
}