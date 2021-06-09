using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //não foi necessário passar parâmetros para o método "Area", pois,
        //os dados necessário para o cálculo da área já estão presentes na classe.
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }

        
    }
}
