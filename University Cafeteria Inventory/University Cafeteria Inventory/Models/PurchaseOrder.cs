using System;
using System.Collections.Generic;

namespace University_Cafeteria_Inventory.Models;

public partial class PurchaseOrder
{
    public int Id { get; set; }

    public DateOnly? OrderDate { get; set; }

    public string? Statuss { get; set; }

    public int? SupplierId { get; set; }

    public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();

    public virtual Supplier? Supplier { get; set; }
}
