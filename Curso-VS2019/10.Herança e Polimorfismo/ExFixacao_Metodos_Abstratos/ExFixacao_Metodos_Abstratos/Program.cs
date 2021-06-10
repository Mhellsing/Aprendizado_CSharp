using System;
using System.Globalization;
using System.Collections.Generic;
using ExFixacao_Metodos_Abstratos.Entities;

namespace ExFixacao_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaDeContribuintes = new List<Pessoa>();

            Console.Write("Informe a quantidade de contribuintes: ");
            var numeroDeContribuintes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroDeContribuintes; i++)
            {
                Console.WriteLine($"\nDados do {i}º contribuinte");
                Console.Write("Tipo de contribuinte (Físico ou Jurídico)? ");
                var tipoDeContribuinte = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());

                Console.Write("Nome: ");
                var nome = Console.ReadLine();

                Console.Write("Renda Anual: R$");
                var rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipoDeContribuinte == "Físico" || tipoDeContribuinte == "Fisico")
                {
                    Console.Write("Valor gasto com saúde: R$");
                    var gastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listaDeContribuintes.Add(new PessoaFisica(nome, rendaAnual, gastosComSaude));
                }
                else
                {
                    Console.Write("Número de funcionários: ");
                    var quantidadeDeFuncionarios = int.Parse(Console.ReadLine());
                    listaDeContribuintes.Add(new PessoaJuridica(nome, rendaAnual, quantidadeDeFuncionarios));
                }
            }

            double sum = 0.0;

            Console.WriteLine("\nImpostos Pagos");
            foreach (Pessoa pessoa in listaDeContribuintes)
            {
                Console.WriteLine($"{pessoa.Nome}: R${pessoa.CalcularImposto().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += pessoa.CalcularImposto();
            }

            Console.WriteLine($"\nArrecadação Total de Impostos - R${sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
