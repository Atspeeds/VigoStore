using _01_Framework.Domain;
using _01_Framework.Infrastrure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.ProductAgg;
using SopeManagement.Application.Contract.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastrure.EFCore.Repository
{
    public class ProductRepository : RepositoryBase<long, Product>, IProductRepository
    {
        private readonly ShopContext _Context;
        public ProductRepository(ShopContext context) : base(context)
        {
            _Context = context;
        }

        public List<ProductViewModel> Search(SearchModel model)
        {
            var query = _Context.products.Select(x => new ProductViewModel
            {
                Code = x.Code,
                Name = x.Name,
                Description = x.Description,
                DateCreate = x.CreationDate.ToShamsi(),
                IsInStock = x.IsInStock,
                Picture = x.Picture,
                Price = x.Price,
                Id=x.Id
            });

            if(!string.IsNullOrWhiteSpace(model.Name))
                query=query.Where(x=>x.Name.Contains(model.Name));

            if (!string.IsNullOrWhiteSpace(model.Code))
                query = query.Where(x => x.Code.Contains(model.Code));

            return query.AsNoTracking().OrderByDescending(x=>x.Id).ToList();
        }

        public EditProduct SelectDetails(long id)
        {
            var product = _Context.products
                .Select(x => new EditProduct()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Description = x.Description,
                    ShortDescription = x.ShortDescription,
                    Slug = x.Slug,
                    KeyWords = x.KeyWords,
                    MetaDescription = x.MetaDescription,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Price = x.Price,    

                }).FirstOrDefault(x => x.Id == id);

            return product;
        }
    }
}
