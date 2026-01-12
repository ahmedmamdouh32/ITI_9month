namespace Task2
{
    internal class Program
    {
        public abstract class Product
        {
            public string Name {  get; set; }
            public decimal Price { get; set; }
            public Product(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
            public Product()
            {

            }
            public virtual string DisplayPrice()
            {
                return $"{Name} costs {Price:C}";
            }
            public abstract string ApplyDiscount(decimal percent);
        }

        public class Electronics : Product
        {
            public Electronics(string name, decimal price):base(name, price)
            {

            }
            public Electronics()
            {

            }
            public override string ApplyDiscount(decimal percent)
            {
                return $"Price after discount : {Price*(1-(percent/100.0m))}";
            }


            public sealed override string DisplayPrice()
            {
                return $"{Name} costs {Price:C}";
            }

            public bool checkWarranty()
            {
                return true;
            }
        }

        public class Clothing : Product
        {
            public Clothing(string name, decimal price) : base(name, price)
            {

            }
            public Clothing()
            {

            }
            public override string ApplyDiscount(decimal percent)
            {
                return $"Price after discount : {Price * (1 - (percent / 100.0m))}";
            }

        }
        public class SpecialOfferProduct : Product
        {
            public SpecialOfferProduct(string name,decimal price):base(name, price)
            {

            }
            public SpecialOfferProduct()
            {

            }
            public override string ApplyDiscount(decimal percent)
            {
                percent += 15;
                return $"Price after discount : {Price * (1 - (percent / 100.0m))}";
            }
        }
        static void Main(string[] args)
        {

            Product[] products =
            {
                new Electronics("Washing Machine", 12000),
                new Clothing("Red T-shirt", 200),
                new SpecialOfferProduct("Dark Pants", 300)
            };

            foreach(Product p in products)
            {
                Console.WriteLine(p.DisplayPrice()+", "+p.ApplyDiscount(10));
            }
            
        }
    }
}
