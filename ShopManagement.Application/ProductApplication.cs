using _0_FrameWork.Application;
using _01_Framework.Application;
using ShopManagement.Domain.ProductAgg;
using SopeManagement.Application.Contract.Product;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public OprationResualt Create(CreateProduct command)
        {
            OprationResualt opration = new OprationResualt();

            if (_productRepository.Exists(x => x.Name == command.Name))
            {
                return opration.Faild(ServiceMessage.DuplicateValue);
            }

            var slug = command.Slug.Slugify();

            var product = new Product(command.Code, command.Name, command.Description,
                command.ShortDescription, command.Price, command.Picture,
                command.PictureAlt, command.PictureTitle, command.KeyWords, command.MetaDescription,slug);

            _productRepository.Add(product);
            _productRepository.Save();

            return opration.Succedded();
        }

        public OprationResualt Edit(EditProduct command)
        {
            OprationResualt opration = new OprationResualt();

            var products = _productRepository.GetById(command.Id);

            if (products != null)
                return opration.Faild(ServiceMessage.EmptyRecord);

            if (_productRepository.Exists(x => x.Name == command.Name && x.Id == command.Id))
                return opration.Faild(ServiceMessage.DuplicateValue);

            var slug= command.Slug.Slugify();

            products.Edit(command.Code, command.Name, command.Description,
                command.ShortDescription, command.Price, command.Picture,
                command.PictureAlt, command.PictureTitle,command.KeyWords,command.MetaDescription,slug);

            _productRepository.Save();

            return opration.Succedded();

        }

        public EditProduct GedDetailss(long id)
        {
            return _productRepository.SelectDetails(id);

        }

        public OprationResualt InStock(long id)
        {
            OprationResualt opration = new OprationResualt();

            var products = _productRepository.GetById(id);

            if (products != null)
                return opration.Faild(ServiceMessage.EmptyRecord);



            if (products.IsInStock == false)
                products.Restore();

            _productRepository.Save();

            return opration.Succedded();
        }

        public OprationResualt NotInStock(long id)
        {
            OprationResualt opration = new OprationResualt();

            var products = _productRepository.GetById(id);

            if (products != null)
                return opration.Faild(ServiceMessage.EmptyRecord);



            if (products.IsInStock == false)
                products.Delete();

            _productRepository.Save();

            return opration.Succedded();
        }

        public List<ProductViewModel> Search(SearchModel model)
        {
            return _productRepository.Search(model);
        }

    }
}
