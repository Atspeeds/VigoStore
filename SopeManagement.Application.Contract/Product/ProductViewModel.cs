namespace SopeManagement.Application.Contract.Product
{
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Code { get;  set; }
        public string Name { get;  set; }
        public string Description { get;  set; }
        public decimal Price { get;  set; }
        public bool IsInStock { get;  set; }
        public string Picture { get;  set; }
        public string DateCreate { get; set; }

    }
}