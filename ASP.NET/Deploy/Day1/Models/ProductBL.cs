namespace Day1.Models
{
    public class ProductBL
    {
        List<Product> Products;
        public ProductBL()
        {
            Products = new List<Product>()
            {
                new Product(){ ID = 1 ,Name="Milk", Description="Fresh Milk",Price = 23, ImagePath="4.webp"},
                new Product(){ ID = 2 ,Name="Meat", Description="Fresh Meat",Price = 230, ImagePath="10.webp"},
                new Product(){ ID = 3 ,Name="Chicken", Description="Fresh Chicken",Price = 170, ImagePath="11.webp"},
                new Product(){ ID = 4 ,Name="TV", Description="Samsung TV 53 inch",Price = 23000, ImagePath="3.webp"},
                new Product(){ ID = 5 ,Name="Camera", Description="Camera Canon 9D",Price = 25500, ImagePath="2.webp"}
            };
        }

        public List<Product> getAll()
        {
            return Products;
        }
        public Product getByIndex(int index)
        {
            return Products.Where(p => p.ID == index).FirstOrDefault() ?? new Product() { Name="not found"};
        }
    }
    
}
