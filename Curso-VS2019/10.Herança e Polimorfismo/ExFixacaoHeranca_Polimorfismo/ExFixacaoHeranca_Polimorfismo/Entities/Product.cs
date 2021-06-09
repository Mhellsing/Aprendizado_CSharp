using System.Globalization;
namespace ExFixacaoHeranca_Polimorfismo.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product (string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $"Common Product: {Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
