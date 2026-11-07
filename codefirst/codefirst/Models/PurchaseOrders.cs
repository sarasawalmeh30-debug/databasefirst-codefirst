

namespace codefirst.Models
{
    public class PurchaseOrders
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public int SuppliersId { get; set; }
        public Suppliers Supplier { get; set; }
        public ICollection<PurchaseOrderItems> PurchaseOrderItemPurchaseOrder { get; set; }
    }
}
