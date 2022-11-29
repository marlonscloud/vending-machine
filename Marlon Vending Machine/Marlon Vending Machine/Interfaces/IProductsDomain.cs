using Marlon_Vending_Machine.Models;

namespace Marlon_Vending_Machine.Interfaces
{
    public interface IProductsDomain
    {
        public IEnumerable<ProductViewModel> GetProducts();
    }
}
