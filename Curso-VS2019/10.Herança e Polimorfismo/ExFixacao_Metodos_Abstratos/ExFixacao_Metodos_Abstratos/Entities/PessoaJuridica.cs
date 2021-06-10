namespace ExFixacao_Metodos_Abstratos.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios) : base(nome, rendaAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }
        public override double CalcularImposto()
        {
            double impostoAPagar;
            double impostoParaEmpresasComAteDezFuncionarios = 0.16;
            double impostoParaEmepsasComMaisDeDezFuncionarios = 0.14;

            if (NumeroDeFuncionarios <= 10)
            {
                impostoAPagar = (RendaAnual * impostoParaEmpresasComAteDezFuncionarios);
            }
            else
                impostoAPagar = (RendaAnual * impostoParaEmepsasComMaisDeDezFuncionarios);

            return impostoAPagar;
        }
    }
}
