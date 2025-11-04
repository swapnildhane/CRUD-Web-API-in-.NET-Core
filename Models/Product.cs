namespace ProductAPI.Models
{
    public class Product
    {
        public int Id { get; set; }          // Primary Key
        public string Name { get; set; }     // Product name
        public decimal Price { get; set; }   // Product price
        public int Quantity { get; set; }    // Stock quantity
    }
}
