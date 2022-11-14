using _01_Framework.Domain;
using SopeManagement.Application.Contract.Product;
using System.Collections.Generic;

namespace ShopManagement.Domain.ProductAgg
{
    public interface IProductRepository:IRepository<long,Product>
    {
        List<ProductViewModel> Search(SearchModel model);
        EditProduct SelectDetails(long id);
    }
}
