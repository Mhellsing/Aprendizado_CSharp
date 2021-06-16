using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao_Com_Interface1.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPaymente
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic payment: ${BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"Tax: ${Tax.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"Total payment: ${TotalPaymente.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
