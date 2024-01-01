namespace CommonLibrary.Entities
{
    public class Product : EntityFieldBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AdditionalInfo { get; set; }

        public ICollection<Tag> Tags { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ProductType ProductType { get; set; }
        public ProductStock ProductStock { get; set; }
        public ICollection<Discount> Discounts { get; set; }
    }
}
