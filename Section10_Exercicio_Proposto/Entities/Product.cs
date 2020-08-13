using System.Text;

namespace Section10_Exercicio_Proposto.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
            Name = "None";
            Price = 0.00;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder s1 = new StringBuilder();
            s1.AppendLine("\n\n   Product Tag ");
            s1.Append("   Name: " + Name);
            s1.Append("\n   Price: $" + Price.ToString("F2"));

            return s1.ToString();
        }
    }
}
