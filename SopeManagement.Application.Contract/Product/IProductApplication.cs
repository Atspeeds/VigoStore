using _01_Framework.Application;
using System.Collections.Generic;

namespace SopeManagement.Application.Contract.Product
{
    public interface IProductApplication
    {
        OprationResualt Create(CreateProduct command);
        OprationResualt Edit(EditProduct command);
        List<ProductViewModel> Search(SearchModel model);
        EditProduct GedDetailss(long id);
        OprationResualt InStock(long id);
        OprationResualt NotInStock(long id);
    }
}
