namespace CommonLibrary.Entities
{
    public class Category : EntityFieldBase
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
