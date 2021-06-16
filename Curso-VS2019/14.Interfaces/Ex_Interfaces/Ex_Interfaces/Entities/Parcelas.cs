using System;

namespace Ex_Interfaces.Entities
{
    class Parcelas
    {
        public DateTime DataDeVenciMentoDaParcela { get; set; }
        public double ValorDaParcela { get; set; }

        public Parcelas(DateTime dataDeVencimentoDaParcela, double valorDaParcela)
        {
            DataDeVenciMentoDaParcela = dataDeVencimentoDaParcela;
            ValorDaParcela = valorDaParcela;
        }

        public override string ToString()
        {
            return $"{DataDeVenciMentoDaParcela.ToString("dd/MM/yyyy")} - {ValorDaParcela}";
        }
    }
}
