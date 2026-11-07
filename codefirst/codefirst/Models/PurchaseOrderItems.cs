
namespace codefirst.Models
{
    public class PurchaseOrderItems
    {
        public int Id { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int PurchaseOrdersId { get; set; }
        public PurchaseOrders PurchaseOrder { get; set; }
        public int ProductsId { get; set; }
        public Products Product { get; set; }
    }
}
