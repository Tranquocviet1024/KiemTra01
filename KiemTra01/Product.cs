namespace KiemTra01
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    public class ShoppingCart
    {
        public List<Product> Products { get; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Price * product.Quantity;
            }
            return total;
        }

        public void ClearCart()
        {
            Products.Clear();
        }
    }
}
