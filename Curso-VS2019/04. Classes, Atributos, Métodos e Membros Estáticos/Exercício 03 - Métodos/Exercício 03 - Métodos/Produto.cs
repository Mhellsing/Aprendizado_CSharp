using System.Globalization;

namespace Exercício_03___Métodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            double total = Preco * Quantidade;
            return total;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
            return;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
                return;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Valor: R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, Estoque: {Quantidade}, Valor total em estoque: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }   
}
