using System.Globalization;
namespace Encapsulamento
{
    class Produto
    {
        //private: o atributo privado não pode ser acessado por outra classe;
        //Por convenção ao nomear o atributo iniciar o nome com underscore "_" e letra minúscula;
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Diferenciar atributos de variáveis locais
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetNome(string nome)//Possível inserir lógicas para definição do nome;
        {
            /*if(nome != null && nome.Length > 1)
            {
                _nome = nome;    
            }*/
            _nome = nome;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{_nome}, ${_preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} unidades, " +
                $"Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}