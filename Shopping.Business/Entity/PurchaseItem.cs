using System;
namespace Shopping.Business.Entity
{
    public class PurchaseItem
    {
        public int PurchaseId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public float SubTotal { get; set; }

        public PurchaseItem (int id, int itemId, int quantity, float subtotal)
        {
            PurchaseId = id;
            ItemId = itemId;
            Quantity = quantity;
            SubTotal = subtotal;
        }
    }
}
