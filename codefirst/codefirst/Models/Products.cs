

namespace codefirst.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int SuppliersId { get; set; }
        public Suppliers Supplier { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public ICollection<PurchaseOrderItems> PurchaseOrderItemProduct { get; set; }
    }
}
