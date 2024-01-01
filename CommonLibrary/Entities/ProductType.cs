namespace CommonLibrary.Entities
{
    public class ProductType : EntityFieldBase
    {
        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<ProductUnit> ProductUnits { get; set; }
    }
}
