namespace CommonLibrary.Entities
{
    public class ProductPrice : EntityFieldBase
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public decimal Price { get; set; }
        public DateTime StartApplicatedDate { get; set; } = DateTime.Now;
        public DateTime EndApplicatedDate { get; set; } = DateTime.Now;
        public Product Product { get; set; }
    }
}
