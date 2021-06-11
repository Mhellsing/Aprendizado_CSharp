using System;

namespace Membros_estáticos
{
    public class Calculculadora
    {
        public static double v = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * v * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3 * v * Math.Pow(r, 3);
        }
    }

}
