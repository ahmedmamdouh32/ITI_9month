using Day1.Models;

namespace Day1.Services
{
    public class ProductService : IService<Product>
    {
        private List<Product> Products { set; get; }
        public ProductService() {
            Products = new List<Product>() 
            {
                new Product(){
                            Name = "Mobile Phone",
                            Id = 1,
                            Quantity = 10,
                            ImageUrl = "https://shop.orange.eg/content/images/thumbs/0011674_iphone-16_550.jpeg",
                            Price = 899.99M},
                 new Product(){
                            Name = "Playstation Console",
                            Id = 2,
                            Quantity = 10,
                            ImageUrl = "https://shop.orange.eg/content/images/thumbs/0005845_sony-dualsense-wireless-controller-for-ps-5.png",
                            Price = 299.99M},
                new Product(){
                            Name = "Laptop",
                            Id = 3,
                            Quantity = 10,
                            ImageUrl = "https://shop.orange.eg/content/images/thumbs/0006076_hp-pavilion-gaming-15-dk2112ne.jpeg",
                            Price = 2599.99M},
                new Product(){
                            Name = "Head Phones",
                            Id = 4,
                            Quantity = 10,
                            ImageUrl = "https://shop.orange.eg/content/images/thumbs/0014926_jbl-tune-520bt.jpeg",
                            Price = 199.99M}
            };
        }
        private int UniqueIds { get; set; } = 1;

        public void Add(Product obj)
        {
            if (obj != null)
            {
                obj.Id = UniqueIds++;
                Products.Add(obj);
            }
        }

        public void Delete(int Id)
        {
            Products.Remove(GetById(Id));
        }

        public Product GetById(int Id)
        {
            return Products.FirstOrDefault(p => p.Id == Id);
        }

        public void Update(int Id, Product obj)
        {
            if(obj != null)
            {
                Product temp = GetById(Id);
                if(temp.Name != null)
                {
                    temp.Name = obj.Name;
                    temp.Price = obj.Price;
                    temp.ImageUrl = obj.ImageUrl;
                    temp.Quantity = obj.Quantity;
                }
            }
        }

        public List<Product> GetAll()
        {
            return Products;
        }
    }
}
