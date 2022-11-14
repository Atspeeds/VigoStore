using _0_FrameWork.Domain;

namespace ShopManagement.Domain.ProductAgg
{
    public class Product : EntitySeo
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string ShortDescription { get; private set; }
        public decimal Price { get; private set; }
        public bool IsInStock { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }


        #region Constroctor Crete Edit Delete Redtore

        public Product() { }
        public Product(string code, string name, string description,
          string shortDescription, decimal price, string picture,
          string pictureAlt, string pictureTitle,string keywords,string metadescription,string slug)
        {
            Code = code;
            Name = name;
            Description = description;
            ShortDescription = shortDescription;
            Price = price;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            IsInStock = true;
            KeyWords= keywords;
            MetaDescription= metadescription;
            Slug = slug;

        }

        public void Edit(string code, string name, string description,
            string shortDescription, decimal price, string picture,
            string pictureAlt, string pictureTitle,
            string keywords, string metadescription, string slug)
        {
            Code = code;
            Name = name;
            Description = description;
            ShortDescription = shortDescription;
            Price = price;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            KeyWords = keywords;
            MetaDescription = metadescription;
            Slug = slug;
        }

        public void Delete()
        {
            IsInStock = false;
        }
        public void Restore()
        {
            IsInStock = true;
        }
        #endregion


    }
}
