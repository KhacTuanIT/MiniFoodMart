namespace CommonLibrary.Entities
{
    public class Tag : EntityFieldBase
    {
        public Guid Id { get; set; }
        public string TagName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
