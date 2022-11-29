namespace Marlon_Vending_Machine.Models
{
    public class ProductViewModel
    {
        public ProductViewModel(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Guid ProductId => Guid.NewGuid();

        public string Name { get; set; }

        public double Price { get; set; }
    }
}