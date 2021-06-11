using System;



namespace ExFixação___02
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double percent)
        {
            SalarioBruto += (percent/100 * SalarioBruto);            
        }

        public override string ToString()
        {
            return $"\nNome: {Nome}\nSalário Líduido - R${SalarioLiquido()}";
        }

    }
}
