namespace Ecommerce.Models.EntityModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
         
    }
}