

namespace codefirst.Models
{
    public class Suppliers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Products> ProductSupplier { get; set; }
        public ICollection<PurchaseOrders> PurchaseOrderSupplier { get; set; }
    }
}
