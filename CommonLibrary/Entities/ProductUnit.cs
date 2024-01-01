namespace CommonLibrary.Entities
{
    public class ProductUnit : EntityFieldBase
    {
        public Guid Id { get; set; }
        public string UnitType { get; set; }
        public string UnitName { get; set; }
        public Guid ProductTypeId { get; set; }
        public ProductType  ProductType { get; set; }
    }
}
