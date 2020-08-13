using System;
using System.Text;

namespace Section10_Exercicio_Proposto.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
            Name = "None";
            Price = 0.00;
            ManufactureDate = DateTime.Now;
        }

        public UsedProduct(string name, double price, DateTime date)
            : base(name, price)
        {
            ManufactureDate = date;
        }

        public override string PriceTag()
        {
            StringBuilder s1 = new StringBuilder();
            s1.AppendLine("\n\n   Product Tag ");
            s1.Append("   Name: " + Name + " (used)");
            s1.Append("\n   Price: $" + Price.ToString("F2"));
            s1.Append("\n   Manufacture date: " + ManufactureDate);

            return s1.ToString();
        }
    }
}
