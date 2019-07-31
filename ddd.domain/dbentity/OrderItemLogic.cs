using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class OrderItem
    {
        public OrderItem() { }
        public OrderItem CreateOrderItem(ProductSKU productsku, int count)
        {
            this.Id = Guid.NewGuid();
            this.Code = "OrderItem " + DateTime.Now.ToString();
            this.Count = count;

            this.OrderItemTotalPrice = new OrderItemTotalPrice().CreateOrderItemTotalPrice(productsku,
                count);
            this.OrderItemTotalPV = new OrderItemTotalPV().CreateOrderItemTotalPV(productsku,
                count);
            this.ProductSKUs = new ProductSKUs().CreateProductSKUs(productsku);
            return this;
        }
    }
}
