using Marlon_Vending_Machine.Interfaces;
using Marlon_Vending_Machine.Models;

namespace Marlon_Vending_Machine.Domains
{
    public class ProductsDomain : IProductsDomain
    {
        public IEnumerable<ProductViewModel> GetProducts()
        {
            var products = new List<ProductViewModel>
            {
                new("Coke", 1.00),
                new("Chips", 0.50),
                new("Candy", 0.65)
            };

            return products;
        }
    }
}
