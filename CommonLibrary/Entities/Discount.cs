namespace CommonLibrary.Entities
{
    public class Discount : EntityFieldBase
    {
        public Guid Id { get; set; }
        public string DiscountName { get; set; }
        public string Description { get; set; }
        public decimal? DiscountAmount { get; set; }
        public DateTime StartApplicatedDate { get; set; } = DateTime.Now;
        public DateTime EndApplicatedDate { get; set; } = DateTime.Now;
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = new Product();
    }
}
