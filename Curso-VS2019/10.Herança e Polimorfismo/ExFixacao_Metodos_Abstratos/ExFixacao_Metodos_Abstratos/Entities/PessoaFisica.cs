namespace ExFixacao_Metodos_Abstratos.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; set; }
        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }
        public override double CalcularImposto()
        {
            double impostosAPagar;
            double impostoParaRendaMenorQueVinteMil = 0.15;
            double impostoParaRendaMaiorOuIgualaVinteMil = 0.25;
            double AbateDeImpostoEmGastosComSaude = 0.50;

            if (RendaAnual < 20000.00)
            {
                impostosAPagar = (RendaAnual * impostoParaRendaMenorQueVinteMil) - (GastosComSaude * AbateDeImpostoEmGastosComSaude);
            }
            else
                impostosAPagar = (RendaAnual * impostoParaRendaMaiorOuIgualaVinteMil) - (GastosComSaude * AbateDeImpostoEmGastosComSaude);
                        
            return impostosAPagar;
        }
    }
}
