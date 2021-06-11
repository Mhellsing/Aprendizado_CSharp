using System;
using System.Globalization;


namespace ExFixação___03
{
    public class Aluno
    {
        public string Nome;
        public double Nota01;
        public double Nota02;
        public double Nota03;

        public double SomatorioDeNotas()
        {
            return Nota01 + Nota02 + Nota03;
        }
        public bool AprovaReprova()
        {
            var somatorio = SomatorioDeNotas();
            var aprovado = somatorio >= 60;

            if (aprovado == true)
            {
                Console.WriteLine("\nParabéns, aluno APROVADO.");
            }
            else
            {
                Console.WriteLine("\nFoque mais nos estudos, aluno REPROVADO.");
                Console.WriteLine($"Faltaram: {60 - somatorio} pontos.");
            }
            return aprovado;
        }
    }


}
