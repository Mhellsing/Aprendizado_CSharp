namespace ExFixação_Vetores
{
    class Produtos
    {
        public string Name{ get; set; }
        public double Price { get; private set; }

        public Produtos(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
