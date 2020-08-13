using System.Text;

namespace Section10_Exercicio_Proposto.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
            Name = "None";
            Price = 0.00;            
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder s1 = new StringBuilder();
            s1.AppendLine("\n\n   Product Tag ");
            s1.Append("   Name: " + Name);
            s1.Append("\n   Price: $" + this.TotalPrice().ToString("F2"));
            s1.Append("\n   Custom fee: $" + CustomsFee.ToString("F2")); 

            return s1.ToString();
        }        
    }
}
