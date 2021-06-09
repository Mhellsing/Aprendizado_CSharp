using System.Globalization;
namespace This
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Diferenciar atributos de variáveis locais
        public Produto(string Nome, double Preco, int Quantidade)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = 20;
        }

        /*public Produto()
         {
             Quantidade = 0;
         }

        Referenciando um construtor em outro construtor;
         public Produto(string nome, double preco) : this()
         {
             Nome = nome;
             Preco = preco;
         }

         //Referenciando um construtor em outro construtor;
         public Produto(string nome, double preco, int quantidade) : this(nome, preco)
         {
             Quantidade = 10;
         }*/

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}