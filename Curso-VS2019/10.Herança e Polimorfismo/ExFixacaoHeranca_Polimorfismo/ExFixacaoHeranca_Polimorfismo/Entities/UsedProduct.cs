using System;
using System.Globalization;
namespace ExFixacaoHeranca_Polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"Used Product: {Name}, ${Price} - (Manufacture Date: {ManufactureDate})";
        }
    }


}
